using Abbyy.CloudSdk.V2.Client;
using Abbyy.CloudSdk.V2.Client.Models;
using Abbyy.CloudSdk.V2.Client.Models.Enums;
using Abbyy.CloudSdk.V2.Client.Models.RequestParams;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Extensions.Http;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UICMA_OCR_Extraction;
using static UICMA_OCR_Extraction.OCRExtractionBO;

namespace UICMA_OCR_Extraction
{
    public class OCRExtraction
    {

 private static string _SqlConnString = string.Empty;
        private static string _errMsg = string.Empty;

        public OCRExtraction(string SqlConnString)
        {
            _SqlConnString = SqlConnString;
        }

        private const string ApplicationId = @"eb67f6ff-55b2-4f09-a47c-f61071476786";
        private const string Password = @"p89fbphaVr6Zm9FzVJue6Mo2";
        /// <summary>
        /// Processing Location URL https://www.ocrsdk.com/documentation/specifications/data-processing-location/
        /// </summary>
        private const string ServiceUrl = "https://cloud.ocrsdk.com";

        private static int _retryCount = 3;
        private static int _delayBetweenRetriesInSeconds = 3;
        private static string _httpClientName = "OCR_HTTP_CLIENT";

        private static readonly AuthInfo AuthInfo = new AuthInfo
        {
            Host = ServiceUrl,
            ApplicationId = ApplicationId,
            Password = Password
        };

        private static Microsoft.Extensions.DependencyInjection.ServiceProvider _serviceProvider;
        private static HttpClient _httpClient;
        public static async Task Main()
        {
            // Init client
            // You could also call GetOcrClient to use client without retry policy
            using (var ocrClient = GetOcrClientWithRetryPolicy())
            {
                // Process image
                // You could also call ProcessDocumentAsync or any other processing method declared below
                var resultUrls = await ProcessImageAsync(ocrClient);

                // Get results
                foreach (var resultUrl in resultUrls)
                    Console.WriteLine(resultUrl);

                // Get list of finished tasks
                var finishedTasks = await GetFinishedTasksAsync(ocrClient);
               //  foreach (var finishedTask in finishedTasks.Tasks)
               //     Console.WriteLine(finishedTask.TaskId);
               
                DisposeServices();
            }
        }

        private static IOcrClient GetOcrClient()
        {
            return new OcrClient(AuthInfo);
        }

        private static IOcrClient GetOcrClientWithRetryPolicy()
        {
            // Create service collection and configure our services
            var services = ConfigureServices();
            // Generate a provider
            _serviceProvider = services.BuildServiceProvider();

            var httpClientFactory = _serviceProvider.GetService<IHttpClientFactory>();
            _httpClient = httpClientFactory.CreateClient(_httpClientName);

            return new OcrClient(_httpClient);
        }

        private static ServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            //Configure HttpClientFactory with retry handler
            services.AddHttpClient(_httpClientName, conf =>
            {
                conf.BaseAddress = new Uri(AuthInfo.Host);
                //increase the default value of timeout for the duration of retries
                conf.Timeout = conf.Timeout + TimeSpan.FromSeconds(_retryCount * _delayBetweenRetriesInSeconds);
            })
                .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
                {
                    PreAuthenticate = true,
                    Credentials = new NetworkCredential(AuthInfo.ApplicationId, AuthInfo.Password)
                })
                //Add  custom HttpClientRetryPolicyHandler with polly
                .AddHttpMessageHandler(() => new HttpClientRetryPolicyHandler(GetRetryPolicy()));

            //or you can use Microsoft.Extensions.DependencyInjection Polly extension
            //.AddPolicyHandler(GetRetryPolicy());
            return services;
        }

        private static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return HttpPolicyExtensions.HandleTransientHttpError()
                //Condition - what kind of request errors should we repeat
                .OrResult(r => r.StatusCode == HttpStatusCode.GatewayTimeout)
                .WaitAndRetryAsync(
                    _retryCount,
                    sleepDurationProvider => TimeSpan.FromSeconds(_delayBetweenRetriesInSeconds),
                    (exception, calculatedWaitDuration, retries, context) =>
                    {
                        Console.WriteLine($"Retry {retries} for policy with key {context.PolicyKey}");
                    }
                )
                .WithPolicyKey("WaitAndRetryAsync_For_GatewayTimeout_504__StatusCode");
        }

        private static async Task<List<string>> ProcessImageAsync(IOcrClient ocrClient)
        {
            // TaskInfo taskin = new TaskInfo();
            // DirectoryInfo directory = new DirectoryInfo(@"D:\Perumal\UICMA\Work from home\Sample");
            // FileInfo[] allFiles = directory.GetFiles();
            // var listOfAllFiles = allFiles.ToList();
            // var listOfCurrentDayFiles = listOfAllFiles.Where(x => (x.CreationTime.Date.ToString("dd/MM/yyyy") == DateTime.Today.Date.ToString("dd/MM/yyyy")) || (x.LastWriteTime.Date.ToString("dd/MM/yyyy") == DateTime.Today.Date.ToString("dd/MM/yyyy"))).ToList();

            // foreach (var files in listOfCurrentDayFiles)
            // {
            //     var imageParams = new ImageProcessingParams
            //     {
            //         ExportFormats = new[] { ExportFormat.Docx, ExportFormat.Txt, },
            //         Language = "English,French",
            //     };
            //     string savePath = @"D:\Perumal\UICMA\Work from home\Sample";
            //     string resultPath = Path.Combine(savePath, files.Name);
            //     using (var fileStream = new FileStream(resultPath, FileMode.Open))
            //     {
            //         var taskInfo = await ocrClient.ProcessImageAsync(
            //             imageParams,
            //             fileStream,
            //             Path.GetFileName(resultPath),
            //             waitTaskFinished: true);

            //         var textFromFile = (new WebClient()).DownloadString(taskInfo.ResultUrls[1]);
            //         var formName = StartOCRProcess(textFromFile);
            //         var currentDate = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            //         if (formName == "ExceptionForm")
            //         {
            //             var saveRootPath = @"E:\UICMA\ocr\ExceptionFolder";
            //             var file = System.IO.Path.Combine(saveRootPath, currentDate + ".txt");
            //             System.IO.File.WriteAllText(file, textFromFile);
            //         }
            //         else
            //         {
            //             var saveRootPath = @"E:\UICMA\ocr\ProcessFolder";
            //             var file = System.IO.Path.Combine(saveRootPath, currentDate + ".txt");
            //             System.IO.File.WriteAllText(file, textFromFile);
            //         }
            //         taskin.ResultUrls = taskInfo.ResultUrls;
            //     }

            // }
            TaskInfo taskin = new TaskInfo();
            DirectoryInfo directory = new DirectoryInfo(ConfigurationManager.AppSettings["InboundPath"].ToString());
            FileInfo[] allFiles = directory.GetFiles();
            var listOfAllFiles = allFiles.ToList();
            foreach (var files in listOfAllFiles)
            {
                 var imageParams = new ImageProcessingParams
                {
                    ExportFormats = new[] { ExportFormat.Docx, ExportFormat.Txt, },
                    Language = "English,French",
                };

                if (files.Extension == ".txt" || files.Extension == ".pdf" || files.Extension == ".jpeg" || files.Extension == ".jpg" || files.Extension == ".png")
                {
                     using (var fileStream = new FileStream(files.FullName, FileMode.Open))
                {
                    var taskInfo = await ocrClient.ProcessImageAsync(
                        imageParams,
                        fileStream,
                        Path.GetFileName(files.FullName),
                        waitTaskFinished: true);
                        
                    var textFromFile = (new WebClient()).DownloadString(taskInfo.ResultUrls[1]);//File.ReadAllText(files.FullName);
               
                    var formName = StartOCRProcess(textFromFile);

                    if (formName.Contains("ExceptionForm"))
                    {
                        var saveRootPath = ConfigurationManager.AppSettings["ExceptionPath"].ToString();
                        Guid guid = Guid.NewGuid();
                        var file = System.IO.Path.Combine(saveRootPath, guid + ".pdf");
                        System.IO.File.WriteAllText(file, textFromFile);
                        SaveException("The form code is not matching");
                    }
                    else
                    {
                        var saveRootPath = ConfigurationManager.AppSettings["ProcessPath"].ToString();
                        var splitClaimId = formName.Split("_");
                        int claimID = Convert.ToInt32(splitClaimId[0]);
                        var documentCode = splitClaimId[1];
                        if(documentCode !="DatasIncorrect")
                        { 
                        Guid guid = Guid.NewGuid();
                        var file = System.IO.Path.Combine(saveRootPath, guid + ".pdf");
                        System.IO.File.WriteAllText(file, textFromFile);                       
                        SaveDocumentMapping(claimID, documentCode, guid);
                        }
                        else
                        {
                            Guid guid = Guid.NewGuid();
                            var file = System.IO.Path.Combine(ConfigurationManager.AppSettings["ExceptionPath"].ToString(), guid + ".pdf");
                            System.IO.File.WriteAllText(file, textFromFile);    
                        }

                    }
                    File.Delete(files.FullName);
                    taskin=taskInfo;
                }
                }
                else
                {
                    SaveException("The file type is not valid");
                }
                
            }
            return taskin.ResultUrls;
        }

        private static async Task<List<string>> ProcessDocumentAsync(IOcrClient ocrClient)
        {
            var taskId = await UploadFilesAsync(ocrClient);

            var processingParams = new DocumentProcessingParams
            {
                ExportFormats = new[] { ExportFormat.Docx, ExportFormat.Txt, },
                Language = "English,French",
                TaskId = taskId,
            };

            var taskInfo = await ocrClient.ProcessDocumentAsync(
                processingParams,
                waitTaskFinished: true);

            return taskInfo.ResultUrls;
        }

        private static async Task<Guid> UploadFilesAsync(IOcrClient ocrClient)
        {
            ImageSubmittingParams submitParams;
            var firstFilePath = "processImage.jpg";
            var secondFilePath = "processDocument.jpg";

            // First file
            using (var fileStream = new FileStream(firstFilePath, FileMode.Open))
            {
                var submitImageResult = await ocrClient.SubmitImageAsync(
                    null,
                    fileStream,
                    Path.GetFileName(firstFilePath));

                // Save TaskId for next files and ProcessDocument method
                submitParams = new ImageSubmittingParams { TaskId = submitImageResult.TaskId };
            }

            // Second file
            using (var fileStream = new FileStream(secondFilePath, FileMode.Open))
            {
                await ocrClient.SubmitImageAsync(
                    submitParams,
                    fileStream,
                    Path.GetFileName(secondFilePath));
            }

            return submitParams.TaskId.Value;
        }

        private static async Task<TaskList> GetFinishedTasksAsync(IOcrClient ocrClient)
        {
            var finishedTasks = await ocrClient.ListFinishedTasksAsync();
            return finishedTasks;
        }

        private static void DisposeServices()
        {
            (_serviceProvider as IDisposable)?.Dispose();
        }
        public static string StartOCRProcess(string text)
        {
            string result = "";
            int getId = 0;
            if (text.Contains("DE 1101CZ"))
            {
                getId = NoticeOfUIClaim(text);
                // if(getId==0)
                // {
                //   SaveException("The Claim field values are Incorrect, Please check the values");
                //   result = getId + "DatasIncorrect";  
                // }
                // else
                // {
                    result = getId + "_DE 1101CZ";
                // }
            }
            else if (text.Contains("DE 4614"))
            {
                getId = ResponseEmployeeComm(text);
                // if(getId==0)
                // {
                //   SaveException("The Response Employee field values are Incorrect, Please check the values");
                //   result = getId + "DatasIncorrect";  
                // }
                // else
                // {
                     result = getId + "_DE 4614";
                // }
                
            }
            else if (text.Contains("DE 1080 EZ") || text.Contains("NOTICE OF DETERMINATION") || text.Contains("NOTICE OF REDETERMINATION"))
            {
                getId = NoticeOfDetermination(text);
                //  if(getId==0)
                // {
                //   SaveException("The Response Employee field values are Incorrect, Please check the values");
                //   result = getId + "DatasIncorrect";  
                // }
                // else
                // {
                   result = getId + "_DE 1080 EZ";
                // }
                
            }
            else if (text.Contains("DE 1326ER"))
            {
                getId = RequestForAdditionalInformation(text);
                
                if(getId==0)
                {
                  SaveException("The Request for Additional Information field values are Incorrect, Please check the values");
                  result = getId + "DatasIncorrect";  
                }
                else
                {
                   result = getId + "_DE 1326ER";
                }
            }

            //else if (text.Contains("DE 1545R"))
            //{
            //	result = "Form 4 -Notice of Wages used UI claim";
            //	//	NoticeOfWages(text);
            //}

            //else if (text.Contains("DE 1000M"))
            //{
            //    result = "Form 5 -Appeal form";
            //    //	AppealForm(text);
            //}
            else if (text.Contains("NOTICE OF HEARING"))
            {
                getId = NoticeOfHearing(text);
               
                if(getId==0)
                {
                  SaveException("The Notice of Hearing field values are Incorrect, Please check the values");
                  result = getId + "DatasIncorrect";  
                }
                else
                {
                    result = getId + "_NOTICE OF HEARING";
                }
            }
            else if (text.Contains("DECISION"))
            {
                getId =  ALJDecision(text);
               
                if(getId==0)
                {
                  SaveException("The Decision field values are Incorrect, Please check the values");
                  result = getId + "DatasIncorrect";  
                }
                else
                {
                    result = getId + "_DECISION";
                }
            }
            //else if (text.Contains("DE 1430"))
            //{
            //    result = "Form 8 -CUIAB board of Appeal";
            //    //	BoardAppeal(text);
            //}
            ////else if (text.Contains("DE 428F"))
            //{
            //    result = "Form 9 -School employee fund employer benefit charges";
            //}
            else if (text.Contains("DE6363"))
            {
                getId = RequestForEmployeeData(text);
                
                // if(getId==0)
                // {
                //   SaveException("The Request for Employee Data field values are Incorrect, Please check the values");
                //   result = getId + "DatasIncorrect";  
                // }
                // else
                // {
                    result = getId + "_DE6363";
                // }
            }
            else if (text.Contains("DE 6586") || text.Contains("DE 6566"))
            {
                getId = WagesAfterAppeal(text);
               
                if(getId==0)
                {
                  SaveException("The Wages After Appeal field values are Incorrect, Please check the values");
                  result = getId + "DatasIncorrect";  
                }
                else
                {
                    result = getId + "_DE 6586";
                }
            }
            else if (text.Contains("DE 1919"))
            {
                getId = RequestForWages(text);
                result = getId + "_DE 1919";
            }
            else if (text.Contains("DE 1296B"))
            {
                getId = BenefitAudit(text);
               
                if(getId==0)
                {
                  SaveException("The Benefit Audit field values are Incorrect, Please check the values");
                  result = getId + "DatasIncorrect";  
                }
                else
                {
                     result = getId + "_DE 1296B";
                }
            }
            else if (text.Contains("DE1S4SR") || text.Contains("DE1545R"))
            {

                getId =  NoticeOfWages(text);
               
                if(getId==0)
                {
                  SaveException("The Notice of Wages field values are Incorrect, Please check the values");
                  result = getId + "DatasIncorrect";  
                }
                else
                {
                     result = getId + "_DE1545R";
                }
            }
            else if (text.Contains("ACKNOWLEDGEMENT LETTER"))
            {
                getId = Acknowledgement(text);
               
                if(getId==0)
                {
                  SaveException("The Acknowledgement field values are Incorrect, Please check the values");
                  result = getId + "DatasIncorrect";  
                }
                else
                {
                    result = getId + "_ACKNOWLEDGEMENT";
                }
            }

            else
            {
                result = "ExceptionForm";
            }

            return result;
        }
        public static long GetClaimBySSN(string ssn)
        {
            Claim claim = new Claim();
            if (_SqlConnString != string.Empty)
                _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

            if (_SqlConnString != string.Empty)
            {
                SqlConnection oraCon = null;
                try
                {
                    using (oraCon = new SqlConnection(_SqlConnString))
                    {
                        oraCon.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = oraCon;
                        cmd.CommandText = "Select * from CLAIM_TBL where SOCIAL_SECURITY_NUMBER='" + ssn + "'";
                        cmd.CommandType = CommandType.Text;

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                claim = (new Claim
                                {
                                    Id = dr["Id"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Id"]),
                                    ClaimantName = dr["CLAIMANT_NAME"] == DBNull.Value ? string.Empty : Convert.ToString(dr["CLAIMANT_NAME"]),
                                    ClaimantStatus = dr["CLAIMANT_STATUS"] == DBNull.Value ? string.Empty : Convert.ToString(dr["CLAIMANT_STATUS"]),
                                    SocialSecurityNumber = dr["SOCIAL_SECURITY_NUMBER"] == DBNull.Value ? string.Empty : Convert.ToString(dr["SOCIAL_SECURITY_NUMBER"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _errMsg = ex.Message;
                }
                finally
                {
                    if (oraCon != null)
                        oraCon.Dispose();
                }
            }
            return claim.Id;

        }
        public static long GetAdditionalInformationBySSN(string ssn)
        {
            AdditionalInformation additionalInfor = new AdditionalInformation();
            if (_SqlConnString != string.Empty)
                _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

            if (_SqlConnString != string.Empty)
            {
                SqlConnection oraCon = null;
                try
                {
                    using (oraCon = new SqlConnection(_SqlConnString))
                    {
                        oraCon.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = oraCon;
                        cmd.CommandText = "Select * from ADDITIONAL_INFORMATION_TBL where SOCIAL_SECURITY_NUMBER='" + ssn + "'";
                        cmd.CommandType = CommandType.Text;

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                additionalInfor = (new AdditionalInformation
                                {
                                    Id = dr["Id"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Id"]),
                                    ClaimId = dr["CLAIM_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CLAIM_ID"]),
                                   
                                    SocialSecurityNumber = dr["SOCIAL_SECURITY_NUMBER"] == DBNull.Value ? string.Empty : Convert.ToString(dr["SOCIAL_SECURITY_NUMBER"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _errMsg = ex.Message;
                }
                finally
                {
                    if (oraCon != null)
                        oraCon.Dispose();
                }
            }
            return additionalInfor.ClaimId;

        }
        public static long GetWagesBySSN(string ssn)
        {
            Wages wages = new Wages();
            if (_SqlConnString != string.Empty)
                _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

            if (_SqlConnString != string.Empty)
            {
                SqlConnection oraCon = null;
                try
                {
                    using (oraCon = new SqlConnection(_SqlConnString))
                    {
                        oraCon.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = oraCon;
                        cmd.CommandText = "Select * from WAGES_TBL where SOCIAL_SECURITY_NUMBER='" + ssn + "'";
                        cmd.CommandType = CommandType.Text;

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                wages = (new Wages
                                {
                                    Id = dr["Id"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Id"]),
                                   
                                    ClaimId = dr["CLAIM_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CLAIM_ID"]),
                                    SocialSecurityNumber = dr["SOCIAL_SECURITY_NUMBER"] == DBNull.Value ? string.Empty : Convert.ToString(dr["SOCIAL_SECURITY_NUMBER"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _errMsg = ex.Message;
                }
                finally
                {
                    if (oraCon != null)
                        oraCon.Dispose();
                }
            }
            return wages.ClaimId;

        }
        public static long GetWagesAfterAppealBySSN(string ssn)
        {
            WagesAfterAppeal wagesAfterApp = new WagesAfterAppeal();
            if (_SqlConnString != string.Empty)
                _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

            if (_SqlConnString != string.Empty)
            {
                SqlConnection oraCon = null;
                try
                {
                    using (oraCon = new SqlConnection(_SqlConnString))
                    {
                        oraCon.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = oraCon;
                        cmd.CommandText = "Select * from WAGES_APPEAL_TBL where SOCIAL_SECURITY_NUMBER='" + ssn + "'";
                        cmd.CommandType = CommandType.Text;

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                wagesAfterApp = (new WagesAfterAppeal
                                {
                                    Id = dr["Id"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Id"]),
                                   
                                    ClaimId = dr["CLAIM_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CLAIM_ID"]),
                                    SocialSecurityNumber = dr["SOCIAL_SECURITY_NUMBER"] == DBNull.Value ? string.Empty : Convert.ToString(dr["SOCIAL_SECURITY_NUMBER"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _errMsg = ex.Message;
                }
                finally
                {
                    if (oraCon != null)
                        oraCon.Dispose();
                }
            }
            return wagesAfterApp.ClaimId;

        }
        public static long GetResponseToEmployerCommBySSN(string ssn)
        {
            ResponseToEmployer responseToEmployer = new ResponseToEmployer();
            if (_SqlConnString != string.Empty)
                _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

            if (_SqlConnString != string.Empty)
            {
                SqlConnection oraCon = null;
                try
                {
                    using (oraCon = new SqlConnection(_SqlConnString))
                    {
                        oraCon.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = oraCon;
                        cmd.CommandText = "Select * from RESPONSE_TO_EMPLOYER_TBL where SOCIAL_SECURITY_NUMBER='" + ssn + "'";
                        cmd.CommandType = CommandType.Text;

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                responseToEmployer = (new ResponseToEmployer
                                {
                                    Id = dr["Id"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Id"]),
                                    ClaimId = dr["CLAIM_ID"] ==  DBNull.Value ? 0 : Convert.ToInt32(dr["CLAIM_ID"]),
                
                                    SocialSecurityNumber = dr["SOCIAL_SECURITY_NUMBER"] == DBNull.Value ? string.Empty : Convert.ToString(dr["SOCIAL_SECURITY_NUMBER"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _errMsg = ex.Message;
                }
                finally
                {
                    if (oraCon != null)
                        oraCon.Dispose();
                }
            }
            return responseToEmployer.ClaimId;

        }
        public static long GetNoticeOfDeterminationBySSN(string ssn)
        {
            ClaimDetermination claimDeter = new ClaimDetermination();
            if (_SqlConnString != string.Empty)
                _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

            if (_SqlConnString != string.Empty)
            {
                SqlConnection oraCon = null;
                try
                {
                    using (oraCon = new SqlConnection(_SqlConnString))
                    {
                        oraCon.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = oraCon;
                        cmd.CommandText = "Select * from CLAIM_DETERMINATION_TBL where SOCIAL_SECURITY_NUMBER='" + ssn + "'";
                        cmd.CommandType = CommandType.Text;

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                claimDeter = (new ClaimDetermination
                                {
                                    Id = dr["Id"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Id"]),
                                    ClaimId = dr["CLAIM_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CLAIM_ID"]),
                                    SocialSecurityNumber = dr["SOCIAL_SECURITY_NUMBER"] == DBNull.Value ? string.Empty : Convert.ToString(dr["SOCIAL_SECURITY_NUMBER"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _errMsg = ex.Message;
                }
                finally
                {
                    if (oraCon != null)
                        oraCon.Dispose();
                }
            }
            return claimDeter.ClaimId;

        }
        public static int NoticeOfUIClaim(string text)
        {
            List<FormIndexMap> formIndex = GetListOfFormDetail("DE 1101CZ");
            Claim claim = new Claim();
            var trimtext = text.Trim();

            //var ClaimantNames = formIndex.Find(x => x.FieldName.Contains("Claimant Name"));
            //var SSNs = formIndex.Find(x => x.FieldName.Contains("Social Security Number"));
            //var ClaimEffectiveDates = formIndex.Find(x => x.FieldName.Contains("Effective Date of Claim"));
            //var LastDayWorkings = formIndex.Find(x => x.FieldName.Contains("Last Day Worked"));
            //var ReasonForSeperations = formIndex.Find(x => x.FieldName.Contains("Reason For Seperation"));
            //var MailDates = formIndex.Find(x => x.FieldName.Contains("Mail Date"));
            //var NewClaims = formIndex.Find(x => x.FieldName.Contains("New Claim"));
            //var AdditionalClaims = formIndex.Find(x => x.FieldName.Contains("Additional Claim"));

            //int climantName1 = Convert.ToInt32(ClaimantNames.PositionTopLeft);  //5063
            //int climantName2 = Convert.ToInt32(ClaimantNames.PositionBottomRight);  //5157
            //string climantName = text.Substring(climantName1, climantName2 - climantName1).Trim();

            //int ssn1 = Convert.ToInt32(SSNs.PositionTopLeft);   //5180
            //int ssn2 = Convert.ToInt32(SSNs.PositionBottomRight);         //5220
            //string ssn = text.Substring(ssn1, ssn2 - ssn1).Trim();

            //int claimEffectiveDate1 = Convert.ToInt32(ClaimEffectiveDates.PositionTopLeft);        //5244
            //int claimEffectiveDate2 = Convert.ToInt32(ClaimEffectiveDates.PositionBottomRight);                     //5331
            //string claimEffectiveDate = text.Substring(claimEffectiveDate1, claimEffectiveDate2 - claimEffectiveDate1).Trim();

            //int lastDayWorked1 = Convert.ToInt32(LastDayWorkings.PositionTopLeft);        //5348
            //int lastDayWorked2 = Convert.ToInt32(LastDayWorkings.PositionBottomRight);     //5394
            //string lastDayWorked = text.Substring(lastDayWorked1, lastDayWorked2 - lastDayWorked1).Trim();

            //int reasonForSeperation1 = Convert.ToInt32(ReasonForSeperations.PositionTopLeft);     //5416
            //int reasonForSeperation2 = Convert.ToInt32(ReasonForSeperations.PositionBottomRight);         //5916
            //string reasonForSeperation = text.Substring(reasonForSeperation1, reasonForSeperation2 - reasonForSeperation1).Trim();

            //int mailDate1 = Convert.ToInt32(MailDates.PositionTopLeft);        //2225
            //int mailDate2 = Convert.ToInt32(MailDates.PositionBottomRight);        //2237
            //string mailDate = text.Substring(mailDate1, mailDate2 - mailDate1).Trim();

            //int newClaim1 = Convert.ToInt32(NewClaims.PositionTopLeft);            //2399
            //int newClaim2 = Convert.ToInt32(NewClaims.PositionBottomRight);           //2563
            //string newClaim = text.Substring(newClaim1, newClaim2 - newClaim1).Trim();

            //int additionalClaim1 = Convert.ToInt32(AdditionalClaims.PositionTopLeft);          //2580
            //int additionalClaim2 = Convert.ToInt32(AdditionalClaims.PositionBottomRight);                 //3481
            //string additionalClaim = text.Substring(additionalClaim1, additionalClaim2 - additionalClaim1).Trim();

            int climantName1 = text.IndexOf("Claimant") + 17;  //5063
            int climantName2 = text.IndexOf("Social Security Number");  //5157
            string climantName = text.Substring(climantName1, climantName2 - climantName1).Trim();

            int ssn1 = text.IndexOf("Social Security Number:") + 23;   //5180
            int ssn2 = text.IndexOf("Effective Date of Claim");         //5220
            string ssn = text.Substring(ssn1, ssn2 - ssn1).Trim();

            int claimEffectiveDate1 = text.IndexOf("Effective Date of Claim:") + 24;        //5244
            int claimEffectiveDate2 = text.IndexOf("Last Date Worked");                     //5331
            string claimEffectiveDate = text.Substring(claimEffectiveDate1, claimEffectiveDate2 - claimEffectiveDate1).Trim();

            int lastDayWorked1 = text.IndexOf("Last Date Worked:") + 17;        //5348
            int lastDayWorked2 = text.IndexOf("Reason for Separation");     //5394
            string lastDayWorked = text.Substring(lastDayWorked1, lastDayWorked2 - lastDayWorked1).Trim();

            int reasonForSeperation1 = text.IndexOf("Reason for Separation:") + 22;     //5416
            int reasonForSeperation2 = text.IndexOf("REPORTING FACTS");         //5916
            string reasonForSeperation = text.Substring(reasonForSeperation1, reasonForSeperation2 - reasonForSeperation1).Trim();

            int mailDate1 = text.IndexOf("Mail Date:") + 10;        //2225
            int mailDate2 = text.IndexOf("Mail Date:") + 22;        //2237
            string mailDate = text.Substring(mailDate1, mailDate2 - mailDate1).Trim();

            int newClaim1 = text.IndexOf("New Claim:") + 10;            //2399
            int newClaim2 = text.IndexOf("Additional Claim");           //2563
            string newClaim = text.Substring(newClaim1, newClaim2 - newClaim1).Trim();

            int additionalClaim1 = text.IndexOf("Additional Claim:") + 17;          //2580
            int additionalClaim2 = text.IndexOf("ACTION REQUIRED");                 //3481
            string additionalClaim = text.Substring(additionalClaim1, additionalClaim2 - additionalClaim1).Trim();

            List<string> listOfValues = text.Split("\r\n").ToList();
            var listWithoutWhiteSpace = listOfValues.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            var states = formIndex.Find(x => x.FieldName.Contains("City"));
            var cities = formIndex.Find(x => x.FieldName.Contains("Address"));

            var trimListOfCity = listWithoutWhiteSpace[states.LineNumber].Trim();
            var trimListOfState = listWithoutWhiteSpace[cities.LineNumber].Trim();
            //var trimListOfCity = listWithoutWhiteSpace[6].Trim();
            //var trimListOfState = listWithoutWhiteSpace[7].Trim();
            var splitListOfCity = trimListOfCity.Split("    ");
            var splitListOfState = trimListOfState.Split("    ");

            var cityandstate = splitListOfCity.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            var address = splitListOfState.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            var zipcode = address[0].ToString().Split('-');
            int claimId = 0;
            // SaveSAPDetail(ssn);
            SAP checkSAPdetails = GetSAPDetailBySSN(ssn);
            if (checkSAPdetails.EmployeeNumber != null)
            {
                Employee emp = GetEmployeeDetailByEmpNo(checkSAPdetails.EmployeeNumber);
                if (emp.EmployeeNumber != null)
                {
                    claim.MailDate = Convert.ToDateTime(mailDate);
                    claim.NewClaim = newClaim;
                    claim.AdditionalClaim = additionalClaim;
                    claim.ClaimantName = climantName;
                    claim.SocialSecurityNumber = ssn;
                    claim.EffectiveDateOfClaim = Convert.ToDateTime(claimEffectiveDate);
                    claim.LastDateWorked = Convert.ToDateTime(lastDayWorked);
                    claim.ReasonForSeparation = reasonForSeperation;
                    claim.ClaimantStatus = "Active";
                    claim.City = zipcode[0];
                    claim.Zipcode = zipcode[1];
                    claim.Address = cityandstate[0];
                    claimId = SaveClaim(claim);

                }
                else
                {
                    SaveException("This Employee Number is not available in Employee table");
                }

            }
            else
            {
                SaveException("This SSN is not available in SAP table");
            }

            return claimId;
        }
        public static int ResponseEmployeeComm(string text)
        {
            List<FormIndexMap> formIndex = GetListOfFormDetail("DE 4614");
            List<string> listOfValues = text.Split("\r\n").ToList();
            var listWithoutWhiteSpace = listOfValues.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            var ClaimantDetails = formIndex.Find(x => x.FieldName.Contains("Claimant Name"));
            var DateDetails = formIndex.Find(x => x.FieldName.Contains("Date Mailed"));
            var PostMarkDates = formIndex.Find(x => x.FieldName.Contains("Post Marked Date"));
            var listOfClimantDetails = listWithoutWhiteSpace[ClaimantDetails.LineNumber];
            var listOfDateDetails = listWithoutWhiteSpace[DateDetails.LineNumber];
            var listOfPostMarkDate = listWithoutWhiteSpace[PostMarkDates.LineNumber];

            //var listOfClimantDetails = listWithoutWhiteSpace[2];
            //var listOfDateDetails = listWithoutWhiteSpace[4];
            var trimListOfClimantDetails = listWithoutWhiteSpace[2].Trim();
            var trimListOfDateDetails = listWithoutWhiteSpace[4].Trim();
            var splitListOfClimantDetails = trimListOfClimantDetails.Split("    ");
            var splitListOfDateDetails = trimListOfDateDetails.Split("    ");

            var climantDetails = splitListOfClimantDetails.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            var dateDetails = splitListOfDateDetails.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            var ssn = climantDetails[1].Trim();
            long checkSSN = GetClaimBySSN(ssn);
            if (checkSSN != 0)
            {
                ResponseToEmployer response = new ResponseToEmployer();
                response.ClaimantName = climantDetails[0].Trim();
                response.SocialSecurityNumber = ssn;
                response.ClaimId=checkSSN;
                response.DateMailed = Convert.ToDateTime(dateDetails[0]);
                response.BenefitYearBeganDate = Convert.ToDateTime(dateDetails[1]);

                if (dateDetails[2].Contains("-"))
                {
                    response.SeperationDate = Convert.ToDateTime(dateDetails[2]);
                }
                if (!listWithoutWhiteSpace[5].Contains("See"))
                {
                    response.PostmarkDate = Convert.ToDateTime(listWithoutWhiteSpace[5]);
                }
                if (response.SocialSecurityNumber.Contains(' '))
                {
                    SaveException("The SSN is not vaild");
                }
                else
                {
                    SaveResponseToEmployer(response);
                }

            }
            else
            {
                SaveException("This SSN is not available in Claim table");
            }

            return Convert.ToInt32(checkSSN);
        }
        public static int RequestForEmployeeData(string text)
        {
            List<FormIndexMap> formIndex = GetListOfFormDetail("DE6363");

            int Date1 = text.IndexOf("Date:") + 5;       
            int Date2 = text.IndexOf("BYB");        
            string mailDate = text.Substring(Date1, Date2 - Date1).Trim();

            int BYB1 = text.IndexOf("BYB:") +4;            //2399
            int BYB2 = text.IndexOf("BYB:")+15;           //2563
            string BYB = text.Substring(BYB1, BYB2 - BYB1).Trim();

            int Claimantname1 = text.IndexOf("CLAIMANT NAME:") + 14;          
            int Claimantname2 = text.IndexOf("CLAIMANT SSN:");                 
            string claimantname = text.Substring(Claimantname1, Claimantname2 - Claimantname1).Trim();

            int ssn1 = text.IndexOf("CLAIMANT SSN:") + 13;        //2225
            int ssn2 = text.IndexOf("Your assistance");        //2237
            string ssn = text.Substring(ssn1, ssn2 - ssn1).Trim();

            int title1 = text.IndexOf("Title :") + 10;            //2399
            int title2 = text.IndexOf("Telephone #");           //2563
            string title = text.Substring(title1, title2 - title1).Trim();

            int telephonenumber1 = text.IndexOf("Telephone #") + 14;         
            int telephonenumber2 = text.IndexOf("Person to contact");                 
            string telephonenumber = text.Substring(telephonenumber1, telephonenumber2 - telephonenumber1).Trim(); 
            
            int completedby1 = text.IndexOf("Completed by:") + 14;        
            int completedby2 = text.IndexOf("Completed by:") + 30;        
            string completedby = text.Substring(completedby1, completedby2 - completedby1).Trim();

            long checkSSN = GetClaimBySSN(ssn);
            if (checkSSN != 0)
            {
                RequestForEmployeeData requestForEmployeeData = new RequestForEmployeeData();
                requestForEmployeeData.ClaimantName = claimantname;
                requestForEmployeeData.SocialSecurityNumber = ssn;
                requestForEmployeeData.ClaimId=checkSSN;
                requestForEmployeeData.Date = Convert.ToDateTime(mailDate);
                requestForEmployeeData.UserTitle = title;
                requestForEmployeeData.UserTelephoneNumber = telephonenumber;
                requestForEmployeeData.UserCompletedBy = completedby;
                requestForEmployeeData.BYBClaimDate = Convert.ToDateTime(BYB);
                SaveRequestForEmployerData(requestForEmployeeData);
            }
            else
            {
                SaveException("This SSN is not available in Claim table");
            }

            return Convert.ToInt32(checkSSN);
        }
        public static int NoticeOfDetermination(string text)
        {
            List<FormIndexMap> formIndex = GetListOfFormDetail("DE 1080 EZ");
            List<string> listOfValues = text.Split("\r\n").ToList();
            var listWithoutWhiteSpace = listOfValues.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            //var ssn = listWithoutWhiteSpace[16].Replace("SSN", " ").Trim();
            //var dateMailed = listWithoutWhiteSpace[5].Replace("DATE MAILED", " ").Trim();
            //var benefitYearBegan = listWithoutWhiteSpace[6].Replace("BENEFIT YEAR BEGAN", " ").Trim();

            //var trimListOfAddressName = listWithoutWhiteSpace[7].Trim();
            //var trimListOfState = listWithoutWhiteSpace[8].Trim();
            //var trimListOfZipcode = listWithoutWhiteSpace[9].Trim();

            var States = formIndex.Find(x => x.FieldName.Contains("State"));
            var SSNs = formIndex.Find(x => x.FieldName.Contains("Social Security Number"));
            var DateMails = formIndex.Find(x => x.FieldName.Contains("Date Mailed"));
            var BenefitYearBeganDates = formIndex.Find(x => x.FieldName.Contains("Benefit Year Began Date"));
            var FormAddress = formIndex.Find(x => x.FieldName.Contains("Address"));
            var Zipcodes = formIndex.Find(x => x.FieldName.Contains("Zipcode"));

            var ssnWithSpace = "";
            if (listWithoutWhiteSpace[SSNs.LineNumber].Contains("SSN"))
            {
                ssnWithSpace = listWithoutWhiteSpace[SSNs.LineNumber].Replace("SSN", " ").Trim();
            }
            else
            {
                ssnWithSpace = listWithoutWhiteSpace[SSNs.LineNumber + 1].Replace("SSN", " ").Trim();

            }

            var ssn = ssnWithSpace.Replace(' ', '-');
            var dateMailed = listWithoutWhiteSpace[DateMails.LineNumber].Replace("DATE MAILED", " ").Trim();
            var benefitYearBegan = listWithoutWhiteSpace[BenefitYearBeganDates.LineNumber].Replace("BENEFIT YEAR BEGAN", " ").Trim();

            var trimListOfAddressName = listWithoutWhiteSpace[FormAddress.LineNumber].Trim();
            var trimListOfState = listWithoutWhiteSpace[States.LineNumber].Trim();
            var trimListOfZipcode = listWithoutWhiteSpace[Zipcodes.LineNumber].Trim();

            var date = "";
            if (dateMailed.Contains("    "))
            {
                var listOfDate = dateMailed.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                date = listOfDate[1].Trim();
            }
            else

            {
                date = dateMailed;
            }
            var splitListOfAddress = trimListOfAddressName.Split("    ");
            var splitListOfState = trimListOfState.Split("    ");
            var splitListOfZipcode = trimListOfZipcode.Split("    ");

            var address = splitListOfAddress.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            var state = splitListOfState.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            var zipcode = splitListOfZipcode.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

            long checkSSN = GetClaimBySSN(ssn);
            if (checkSSN != 0)
            {
                ClaimDetermination claimDetemination = new ClaimDetermination();
                claimDetemination.FieldOffice = address[0] + "," + state[0] + "," + zipcode[0];
                claimDetemination.SocialSecurityNumber = ssn;
                claimDetemination.ClaimId=checkSSN;
                claimDetemination.MailedDate = Convert.ToDateTime(date);
                claimDetemination.BenefitYearBegan = Convert.ToDateTime(benefitYearBegan);
                SaveCalimDetermination(claimDetemination);

            }
            else
            {
                SaveException("This SSN is not available in Claim table");
            }
            return Convert.ToInt32(checkSSN);
        }
        public static int RequestForAdditionalInformation(string text)
        {
            List<FormIndexMap> formIndex = GetListOfFormDetail("DE 1326ER");
            var dates = formIndex.Find(x => x.FieldName.Contains("Mail Date"));
            List<string> listOfValues = text.Split("\r\n").ToList();
            var listWithoutWhiteSpace = listOfValues.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            int claimantName1 = text.IndexOf("Name:") + 5;
            int claimantName2 = text.IndexOf("If one");
            var claimantName = text.Substring(claimantName1, claimantName2 - claimantName1).Trim();
            int ssn1 = text.IndexOf("Social Security number (SSN):") + 29;
            int ssn2 = text.IndexOf("Claim Effective");
            var ssn = text.Substring(ssn1, ssn2 - ssn1).Trim();
            int claimEffectiveDate1 = text.IndexOf("Claim Effective Date:") + 21;
            int claimEffectiveDate2 = text.IndexOf("Name:");
            var claimEffectiveDate = text.Substring(claimEffectiveDate1, claimEffectiveDate2 - claimEffectiveDate1).Trim();
            //int controlNumber1 = text.IndexOf("Control #:") + 10;
            //int controlNumber2 = text.IndexOf("If one");
            //var controlNumber = text.Substring(controlNumber1, controlNumber2 - controlNumber1).Trim();
            var trimListOfMailDate = "" ;
            if (listWithoutWhiteSpace[dates.LineNumber].Contains("Mail Date"))
            {
                trimListOfMailDate = listWithoutWhiteSpace[dates.LineNumber].Trim();
            }
            else
            {
                trimListOfMailDate = listWithoutWhiteSpace[dates.LineNumber+1].Trim();
            }
            var date = trimListOfMailDate.Replace("Mail Date:", "").Trim();


            long checkSSN = GetClaimBySSN(ssn);
            if (checkSSN != 0)
            {

                AdditionalInformation additionalInformation = new AdditionalInformation();
                additionalInformation.ClaimantName = claimantName;
                additionalInformation.SocialSecurityNumber = ssn;
                additionalInformation.ClaimId=checkSSN;
                additionalInformation.MailDate = Convert.ToDateTime(date);
                additionalInformation.ClaimEffectiveDate = Convert.ToDateTime(claimEffectiveDate);
                additionalInformation.ControlNumber = "test";//controlNumber;
                SaveAdditionalInformation(additionalInformation);
            }
            else
            {
                SaveException("This SSN is not available in Claim table");
            }

            return Convert.ToInt32(checkSSN);
        }
        public static int ALJDecision(string text)
        {
            List<FormIndexMap> formIndex = GetListOfFormDetail("DECISION");
            List<string> listOfValues = text.Split("\r\n").ToList();
            var listWithoutWhiteSpace = listOfValues.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            ALJDecision ALJdecision = new ALJDecision();
            var caseNumber = "";
            var formerlyCaseNumber = "";
            var claimantName = "";
          //  var employerInfo = "";
          //  var applicationReopenDate = "";
            var bYBClaimDate = "";
            var hearingDate = "";
            var hearingPlace = "";
            var partiesAppearing = "";
            var decision = ""; 
            var aLJName = "";
            var city = "";
            var address = "";
            var accountNumber = "";

            var caseNumbers = formIndex.Find(x => x.FieldName.Contains("Case Number"));
            var formerlyCaseNumbers = formIndex.Find(x => x.FieldName.Contains("Formerly Case Number"));
            var employerInfos = formIndex.Find(x => x.FieldName.Contains("Employer Details"));
            var applicationReopens = formIndex.Find(x => x.FieldName.Contains("Application Reopen"));
            var employerInformations = formIndex.Find(x => x.FieldName.Contains("Employer Information"));
            var hearingDates = formIndex.Find(x => x.FieldName.Contains("Hearing Date"));
            var dateMails = formIndex.Find(x => x.FieldName.Contains("Date Mailed"));
            var ALJNames = formIndex.Find(x => x.FieldName.Contains("ALJ Name"));

            if(text.Contains("Formerly Case No"))
            {
                var FormerlyCaseNumber = listWithoutWhiteSpace[formerlyCaseNumbers.LineNumber];
                var CaseNumber = listWithoutWhiteSpace[caseNumbers.LineNumber];
                var Address1 = listWithoutWhiteSpace[employerInfos.LineNumber];
                var Address2 = listWithoutWhiteSpace[applicationReopens.LineNumber];
                var Address3 = listWithoutWhiteSpace[employerInformations.LineNumber];
                var HearingDate = listWithoutWhiteSpace[hearingDates.LineNumber];
                var ALJName12 = "";
                if (listWithoutWhiteSpace[ALJNames.LineNumber].Contains("Administrative Law Judge"))
                {
                    ALJName12 = listWithoutWhiteSpace[ALJNames.LineNumber];
                }
                else
                {
                    ALJName12 = listWithoutWhiteSpace[ALJNames.LineNumber+1];
                }
                var claimnanmme = listWithoutWhiteSpace[caseNumbers.LineNumber];
                var splitCaseNumber = CaseNumber.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                var splitHiringDate = HearingDate.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                var splitClaimantname = claimnanmme.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                var splitALJName = ALJName12.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                var splitAddress1 = Address1.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                var splitAddress2 = Address2.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                var splitAddress3 = Address3.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                var splitFormerlyCaseNumber =FormerlyCaseNumber.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

                var PCaseNumber = splitCaseNumber[1];
                address = splitAddress1[0].Trim();
                city = splitAddress2[0].Trim();
                accountNumber = splitAddress3[0].Trim();
                var PHearingDate = splitHiringDate[0];
                var PFormerlyCaseNumber = splitFormerlyCaseNumber[1];
                var PALJName = splitALJName[0];
                partiesAppearing = splitHiringDate[1].Trim();
               claimantName = splitClaimantname[0].Trim();

                caseNumber = PCaseNumber.Replace("-", "").Replace("Reopened", "").Replace("Case No.", "").Trim();
                formerlyCaseNumber = PFormerlyCaseNumber.Replace("Formerly Case No.", "").Replace("(","").Replace(")","").Trim();
                int BYBDate1 = text.IndexOf("BYB: ") + 5;
                int BYBDate2 = text.IndexOf("BYB:")+25;
                bYBClaimDate = text.Substring(BYBDate1, BYBDate2 - BYBDate1).Trim();
                var hearingDate1 = PHearingDate.Replace("(1)", "").Replace("( 1 )","").Trim();
                var hearing = hearingDate1.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s)).ToList(); ;
                 hearingDate = hearing[0].Trim();
                 hearingPlace = hearing[1].Trim();
                if (hearing.Count == 3)
                    hearingPlace = hearing[1] +' '+ hearing[2].Trim();
                 aLJName = PALJName.Replace("Administrative Law Judge", "").Replace(",","");
                int decision1 = text.IndexOf("DECISION") + 8;
                int decision2 = text.IndexOf("1-800-300-5616.") + 15;
                 decision = text.Substring(decision1, decision2 - decision1).Trim();
                var reopenDate = "";
                if(text.Contains("Date of Application to Vacate:"))
                {
                    int reopen1 = text.IndexOf("Date of Application to Vacate:") + 30;
                    int reopn2 = text.IndexOf("Date of Application to Vacate:") + 50;
                    reopenDate = text.Substring(reopen1, reopn2 - reopen1).Trim();
                }
                if(text.Contains("Date of Application to Reopen:"))
                {
                    int reopen1 = text.IndexOf("Date of Application to Reopen:") + 30;
                    int reopen2 = text.IndexOf("Date of Application to Reopen:") + 50;
                    reopenDate = text.Substring(reopen1, reopen2 - reopen1).Trim();
                }

                ALJdecision.CaseNumber = caseNumber;
                ALJdecision.FormerlyCaseNumber = formerlyCaseNumber;
                ALJdecision.ClaimantName = claimantName;
                ALJdecision.EmployerInfo = address+',' + city+',' + accountNumber;
                ALJdecision.ApplicationReopenDate = Convert.ToDateTime(reopenDate);
                ALJdecision.BYBClaimDate = Convert.ToDateTime(bYBClaimDate);
                ALJdecision.HearingDate = Convert.ToDateTime(hearingDate);
                ALJdecision.HearingPlace = hearingPlace;
                ALJdecision.PartiesAppearing = partiesAppearing;
                ALJdecision.Decision = decision;
                ALJdecision.ALJName = aLJName;
            }

            else
            {
                if(listWithoutWhiteSpace[4].Contains("Case No"))
                {

                    var CaseNumber = listWithoutWhiteSpace[caseNumbers.LineNumber-1];
                    var Address1 = listWithoutWhiteSpace[employerInfos.LineNumber-1];
                    var Address2 = listWithoutWhiteSpace[applicationReopens.LineNumber-1];
                    var Address3 = listWithoutWhiteSpace[employerInformations.LineNumber-1];
                    var HearingDate = listWithoutWhiteSpace[hearingDates.LineNumber-2];
                    var PALJName = "";
                    if (listWithoutWhiteSpace[ALJNames.LineNumber].Contains("Administrative Law Judge"))
                    {
                        PALJName = listWithoutWhiteSpace[ALJNames.LineNumber];
                    }
                    if (listWithoutWhiteSpace[ALJNames.LineNumber - 1].Contains("Administrative Law Judge"))
                    {
                        PALJName = listWithoutWhiteSpace[ALJNames.LineNumber - 1];
                    }
                    if (listWithoutWhiteSpace[ALJNames.LineNumber - 2].Contains("Administrative Law Judge"))
                    {
                        PALJName = listWithoutWhiteSpace[ALJNames.LineNumber - 2];
                    }
                    var claimnanmme = listWithoutWhiteSpace[caseNumbers.LineNumber-1];
                    var splitCaseNumber = CaseNumber.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitHiringDate = HearingDate.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitClaimantname = claimnanmme.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitALJName = PALJName.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitAddress1 = Address1.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitAddress2 = Address2.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitAddress3 = Address3.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

                    var PCaseNumber = splitCaseNumber[1];
                    address = splitAddress1[0].Trim();
                    city = splitAddress2[0].Trim();
                    accountNumber = splitAddress3[0].Trim();
                    var PHearingDate = splitHiringDate[0];
                    var ALJName = splitALJName[0];
                    partiesAppearing = splitHiringDate[1].Trim();
                    claimantName = splitClaimantname[0].Trim();

                    caseNumber = PCaseNumber.Replace("-", "").Replace("Reopened", "").Replace("Case No.", "").Trim();
                    int BYBDate1 = text.IndexOf("BYB: ") + 5;
                    int BYBDate2 = text.IndexOf("BYB:") + 25;
                    bYBClaimDate = text.Substring(BYBDate1, BYBDate2 - BYBDate1).Trim();
                    var hearingDate1 = PHearingDate.Replace("(1)", "").Replace("( 1 )", "").Trim();
                    var hearing = hearingDate1.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s)).ToList(); ;
                    hearingDate = hearing[0].Trim();
                    hearingPlace = hearing[1].Trim();
                    if (hearing.Count == 3)
                        hearingPlace = hearing[1] + ' ' + hearing[2].Trim();
                    aLJName = ALJName.Replace("Administrative Law Judge", "").Replace(",", "");
                    if (text.Contains("DECISION DISMISSING APPEAL FOR NONAPPEARANCE") || text.Contains("DECISION DISMISSING APPEAL DUE TO WITHDRAWAL"))
                    {
                        int decision1 = text.IndexOf("DECISION DISMISSING APPEAL") + 45;
                        int decision2 = text.IndexOf("is dismissed") + 12;
                        decision = text.Substring(decision1, decision2 - decision1).Trim();
                    }
                    else
                    {
                        int decision1 = text.IndexOf("DECISION") + 8;
                        int decision2 = text.IndexOf("1-800-300-5616.") + 15;
                        decision = text.Substring(decision1, decision2 - decision1).Trim();
                    }

                    ALJdecision.CaseNumber = caseNumber;
                    ALJdecision.ClaimantName = claimantName;
                    ALJdecision.EmployerInfo = address + ',' + city + ',' + accountNumber;
                    ALJdecision.BYBClaimDate = Convert.ToDateTime(bYBClaimDate);
                    ALJdecision.HearingDate = Convert.ToDateTime(hearingDate);
                    ALJdecision.HearingPlace = hearingPlace;
                    ALJdecision.PartiesAppearing = partiesAppearing;
                    ALJdecision.Decision = decision;
                    ALJdecision.ALJName = aLJName;

                }
                if (listWithoutWhiteSpace[6].Contains("Case No"))
                {
                    var CaseNumber = listWithoutWhiteSpace[caseNumbers.LineNumber + 1];
                    var Address1 = listWithoutWhiteSpace[employerInfos.LineNumber + 1];
                    var Address2 = listWithoutWhiteSpace[applicationReopens.LineNumber + 1];
                    var Address3 = listWithoutWhiteSpace[employerInformations.LineNumber + 1];
                    var HearingDate = listWithoutWhiteSpace[hearingDates.LineNumber];
                    var PALJName = "";
                    if (listWithoutWhiteSpace[ALJNames.LineNumber].Contains("Administrative Law Judge"))
                    {
                        PALJName = listWithoutWhiteSpace[ALJNames.LineNumber];
                    }
                    if (listWithoutWhiteSpace[ALJNames.LineNumber - 1].Contains("Administrative Law Judge"))
                    {
                        PALJName = listWithoutWhiteSpace[ALJNames.LineNumber - 1];
                    }
                    if (listWithoutWhiteSpace[ALJNames.LineNumber - 2].Contains("Administrative Law Judge"))
                    {
                        PALJName = listWithoutWhiteSpace[ALJNames.LineNumber - 2];
                    }
                    var claimnanmme = listWithoutWhiteSpace[caseNumbers.LineNumber + 1];
                    var splitCaseNumber = CaseNumber.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitHiringDate = HearingDate.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitClaimantname = claimnanmme.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitALJName = PALJName.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitAddress1 = Address1.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitAddress2 = Address2.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitAddress3 = Address3.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

                    var PCaseNumber = splitCaseNumber[1];
                    address = splitAddress1[0].Trim();
                    city = splitAddress2[0].Trim();
                    accountNumber = splitAddress3[0].Trim();
                    var PHearingDate = splitHiringDate[0];
                    var ALJName = splitALJName[0];
                    partiesAppearing = splitHiringDate[1].Trim();
                    claimantName = splitClaimantname[0].Trim();

                    caseNumber = PCaseNumber.Replace("-", "").Replace("Reopened", "").Replace("Case No.", "").Trim();
                    int BYBDate1 = text.IndexOf("BYB: ") + 5;
                    int BYBDate2 = text.IndexOf("BYB:") + 25;
                    bYBClaimDate = text.Substring(BYBDate1, BYBDate2 - BYBDate1).Trim();
                    var hearingDate1 = PHearingDate.Replace("(1)", "").Replace("( 1 )", "").Trim();
                    var hearing = hearingDate1.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s)).ToList(); ;
                    hearingDate = hearing[0].Trim();
                    hearingPlace = hearing[1].Trim();
                    if (hearing.Count == 3)
                        hearingPlace = hearing[1] + ' ' + hearing[2].Trim();
                    aLJName = ALJName.Replace("Administrative Law Judge", "").Replace(",", "");
                    if (text.Contains("DECISION DISMISSING APPEAL FOR NONAPPEARANCE") || text.Contains("DECISION DISMISSING APPEAL DUE TO WITHDRAWAL"))
                    {
                        int decision1 = text.IndexOf("DECISION DISMISSING APPEAL") + 45;
                        int decision2 = text.IndexOf("is dismissed") + 12;
                        decision = text.Substring(decision1, decision2 - decision1).Trim();
                    }
                    else
                    {
                        int decision1 = text.IndexOf("DECISION") + 8;
                        int decision2 = text.IndexOf("1-800-300-5616.") + 15;
                        decision = text.Substring(decision1, decision2 - decision1).Trim();
                    }

                    ALJdecision.CaseNumber = caseNumber;
                    ALJdecision.ClaimantName = claimantName;
                    ALJdecision.EmployerInfo = address + ',' + city + ',' + accountNumber;
                    ALJdecision.BYBClaimDate = Convert.ToDateTime(bYBClaimDate);
                    ALJdecision.HearingDate = Convert.ToDateTime(hearingDate);
                    ALJdecision.HearingPlace = hearingPlace;
                    ALJdecision.PartiesAppearing = partiesAppearing;
                    ALJdecision.Decision = decision;
                    ALJdecision.ALJName = aLJName;

                }
                else
                {                   
                    var CaseNumber = listWithoutWhiteSpace[caseNumbers.LineNumber];
                    var Address1 = listWithoutWhiteSpace[employerInfos.LineNumber];
                    var Address2 = listWithoutWhiteSpace[applicationReopens.LineNumber];
                    var Address3 = listWithoutWhiteSpace[employerInformations.LineNumber];
                    var HearingDate = listWithoutWhiteSpace[hearingDates.LineNumber];
                    var PALJName = "";
                    if (listWithoutWhiteSpace[ALJNames.LineNumber].Contains("Administrative Law Judge"))
                    {
                        PALJName = listWithoutWhiteSpace[ALJNames.LineNumber];
                    }
                    if (listWithoutWhiteSpace[ALJNames.LineNumber-1].Contains("Administrative Law Judge"))
                    {
                        PALJName = listWithoutWhiteSpace[ALJNames.LineNumber - 1];
                    }
                    if (listWithoutWhiteSpace[ALJNames.LineNumber-2].Contains("Administrative Law Judge"))
                    {
                        PALJName = listWithoutWhiteSpace[ALJNames.LineNumber -2];
                    }
                    var claimnanmme = listWithoutWhiteSpace[caseNumbers.LineNumber];
                    var HDate = "";
                    if(HearingDate.Contains("DECISION"))
                    {
                        HDate = listWithoutWhiteSpace[hearingDates.LineNumber-1];
                    }
                    else
                    {
                        HDate = HearingDate;
                    }
                    var splitCaseNumber = CaseNumber.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitHiringDate = HDate.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitClaimantname = claimnanmme.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitALJName = PALJName.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitAddress1 = Address1.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitAddress2 = Address2.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                    var splitAddress3 = Address3.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                  
                    var PCaseNumber = splitCaseNumber[1];
                    address = splitAddress1[0].Trim();
                    city = splitAddress2[0].Trim();
                    accountNumber = splitAddress3[0].Trim();
                    var PHearingDate = splitHiringDate[0];
                    var ALJName = splitALJName[0];
                    partiesAppearing = splitHiringDate[1].Trim();
                    claimantName = splitClaimantname[0].Trim();

                    caseNumber = PCaseNumber.Replace("-", "").Replace("Reopened", "").Replace("Case No.", "").Trim();
                    int BYBDate1 = text.IndexOf("BYB: ") + 5;
                    int BYBDate2 = text.IndexOf("BYB:") + 25;
                    bYBClaimDate = text.Substring(BYBDate1, BYBDate2 - BYBDate1).Trim();
                    var hearingDate1 = PHearingDate.Replace("(1)", "").Replace("( 1 )", "").Trim();
                    var hearing = hearingDate1.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s)).ToList(); ;
                    hearingDate = hearing[0].Trim();
                    hearingPlace = hearing[1].Trim();
                    if (hearing.Count == 3)
                        hearingPlace = hearing[1] + ' ' + hearing[2].Trim();
                    aLJName = ALJName.Replace("Administrative Law Judge", "").Replace(",", "");
                    if (text.Contains("DECISION DISMISSING APPEAL FOR NONAPPEARANCE") || text.Contains("DECISION DISMISSING APPEAL DUE TO WITHDRAWAL"))
                    {
                        int decision1 = text.IndexOf("DECISION DISMISSING APPEAL") + 45;
                        int decision2 = text.IndexOf("is dismissed") + 12;
                        decision = text.Substring(decision1, decision2 - decision1).Trim();
                    }
                    else
                    {
                        int decision1 = text.IndexOf("DECISION") + 8;
                        int decision2 = text.IndexOf("1-800-300-5616.") + 15;
                        decision = text.Substring(decision1, decision2 - decision1).Trim();
                    }

                    ALJdecision.CaseNumber = caseNumber;
                    ALJdecision.ClaimantName = claimantName;
                    ALJdecision.EmployerInfo = address + ',' + city + ',' + accountNumber;
                    ALJdecision.BYBClaimDate = Convert.ToDateTime(bYBClaimDate);
                    if(hearingDate !=null)
                    ALJdecision.HearingDate = Convert.ToDateTime(hearingDate);
                    ALJdecision.HearingPlace = hearingPlace;
                    ALJdecision.PartiesAppearing = partiesAppearing;
                    ALJdecision.Decision = decision;
                    ALJdecision.ALJName = aLJName;

                }

            }


            //long checkSSN = GetClaimBySSN(ssn);
            //if (checkSSN != 0)
            //{

                SaveALJDecision(ALJdecision);

            //}
            //else
            //{
            //    SaveException("This SSN is not available in Claim table");
            //}

            //return Convert.ToInt32(checkSSN);
            return 0;
        }
        public static int NoticeOfHearing(string text)
        {

            List<FormIndexMap> formIndex = GetListOfFormDetail("NOTICE OF HEARING");
            List<string> listOfValues = text.Split("\r\n").ToList();
            var listWithoutWhiteSpace = listOfValues.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            var caseNumbers = formIndex.Find(x => x.FieldName.Contains("Case Number"));
            var hearingDates = formIndex.Find(x => x.FieldName.Contains("Hearing Date"));
            var hearingTimes = formIndex.Find(x => x.FieldName.Contains("Hearing Time"));
            var places = formIndex.Find(x => x.FieldName.Contains("Place"));
            var formAddress = formIndex.Find(x => x.FieldName.Contains("Address"));
            var employerOffice = formIndex.Find(x => x.FieldName.Contains("Employer Office"));

            var trimListofCaseNumber = listWithoutWhiteSpace[caseNumbers.LineNumber].Trim();
            var trimListOfHearingDate = listWithoutWhiteSpace[hearingDates.LineNumber].Trim();
            var trimListOfHearingTime = listWithoutWhiteSpace[hearingTimes.LineNumber].Trim();
            var trimListOfPlace = listWithoutWhiteSpace[places.LineNumber].Trim();
            var trimListOfAddress = listWithoutWhiteSpace[formAddress.LineNumber].Trim();
            var trimListOfEmployerOffice = listWithoutWhiteSpace[employerOffice.LineNumber].Trim();

            var splitListOfCaseNumber = trimListofCaseNumber.Split("    ").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            var splitListOfHearingDate = trimListOfHearingDate.Split("                     ").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            var splitListOfHearingTime = trimListOfHearingTime.Split("                     ").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            var splitListOfPlace = trimListOfPlace.Split("                     ").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            var splitListOfAddress = trimListOfAddress.Split("    ").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            var splitListOfEmployerOffice = trimListOfEmployerOffice.Split("    ").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            //var hearingDate = "";            
            var caseNumber = splitListOfCaseNumber[0].Replace("Case No.", "").Trim();
            //if(splitListOfHearingDate[0].Contains("DATE"))
            //    hearingDate= splitListOfHearingDate[0].Replace("'", " ").Replace("DATE:", " ").Replace("I DATE:", " ").Trim();
            //else
            //    hearingDate= splitListOfHearingDate[1].Replace("'", " ").Replace("DATE:", " ").Replace("I DATE:", " ").Trim();
            //var hearingtime = "";
            //if(splitListOfHearingTime[0].Contains("TIME"))
            //    hearingtime = splitListOfHearingTime[0].Replace("TIME:", "").Trim();
            //else
            //    hearingtime = splitListOfHearingTime[1].Replace("TIME:", "").Trim();

            int hearingDate1 = text.IndexOf("DATE:") + 5;
            int hearingDate2 = text.IndexOf("DATE:") + 45;
            var hearingDateWithSpace = text.Substring(hearingDate1, hearingDate2 - hearingDate1).Trim();
            var hearingDateSplitBySpace = hearingDateWithSpace.Split("  ");
            var hearingDate = hearingDateSplitBySpace[0];

            int hearingTime1 = text.IndexOf("TIME:") + 5;
            int hearingTime2 = text.IndexOf("TIME:") + 35;
            var hearingTimeWithSpace = text.Substring(hearingTime1, hearingTime2 - hearingTime1).Trim();
            var hearingTimeSplitBySpace = hearingTimeWithSpace.Split("  ");
            var hearingtime = hearingTimeSplitBySpace[0];

            var address = "";
            if (splitListOfAddress.Count() == 1)
            {
                address = splitListOfAddress[0].Trim();
            }
            else
            {
                address = splitListOfAddress[1].Trim();
            }
            var employerinfo = splitListOfAddress[0]+','+ splitListOfEmployerOffice[0];
            var place = "";
            if (splitListOfPlace.Count() == 1)
            {
                place = splitListOfPlace[0].Replace("PLACE:", "").Replace("j","").Trim();
            }
            else
            {
                place = splitListOfPlace[1].Replace("PLACE:", "").Replace("j", "").Trim();
            }
            int appellant1 = text.IndexOf("-Appellant") - 8;
            int appellant2 = text.IndexOf("-Appellant");
            var appellant = text.Substring(appellant1, appellant2 - appellant1).Trim();
            var claimantname = "";
            if (splitListOfHearingDate[0].Contains("Formerly Case No"))
            {
                claimantname = splitListOfHearingTime[0].Trim();
            }
            else
            {
                claimantname = splitListOfHearingDate[0].Trim();
            }

            
            Hearing hearing = new Hearing();
            hearing.CaseNumber = caseNumber;
            hearing.HearingDate = Convert.ToDateTime(hearingDate);
            hearing.HearingTime = hearingtime;
            hearing.ClaimantName = claimantname;
            hearing.EDDOffice = employerinfo.Trim();
            hearing.HearingPlace = place + ','+address;
            hearing.AppellantName = appellant;
             SaveHearing(hearing);

            //long checkSSN = GetClaimBySSN(ssn);
            //if (checkSSN != 0)
            //{
            //    Hearing hearing = new Hearing();
            //    hearing.CaseNumber = caseNumber;
            //    hearing.HearingDate = Convert.ToDateTime(hearingDate);
            //    hearing.HearingTime = hearingtime;
            //    hearing.ClaimantName = splitListOfHearingDate[0];
            //    hearing.EDDOffice = employerinfo.Trim();
            //    hearing.HearingPlace = place + address;
            //    hearing.AppellantName = appellant;
            //    SaveHearing(hearing);

            //}
            //else
            //{
            //    SaveException("This SSN is not available in Claim table");
            //}

            return 13;  //Convert.ToInt32(checkSSN);


        }
        public static int Acknowledgement(string text)
        {
            List<string> listOfValues = text.Split("\r\n").ToList();
            var listWithoutWhiteSpace = listOfValues.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            int ABCaseNo1 = text.IndexOf("AB Case No.:")+12;
            int ABCaseNo2 = text.IndexOf("AB Case No.:")+22;
            var ABCaseno = text.Substring(ABCaseNo1, ABCaseNo2 - ABCaseNo1).Trim();

            int ALJDecisionNo1 = text.IndexOf("ALJ Decision No.:") +17;
            int ALJDecisionNo2 = text.IndexOf("ALJ Decision No.:")+26;
            var ALJDecisionNo = text.Substring(ALJDecisionNo1, ALJDecisionNo2 - ALJDecisionNo1).Trim();

            int appellant1 = text.IndexOf("Appellant:") +10;
            int appellant2 = text.IndexOf("Appellant:")+20;
            var appellant = text.Substring(appellant1, appellant2 - appellant1).Trim();

            int DateMailed1 = text.IndexOf("Date Mailed:")+ 12;
            int DateMailed2 = text.IndexOf("Date Mailed:")+32;
            var dateMailed = text.Substring(DateMailed1, DateMailed2 - DateMailed1).Trim();

            CUIABAcknowledgement acknowlwdgement = new CUIABAcknowledgement();
            acknowlwdgement.ABCaseNumber = ABCaseno;
            acknowlwdgement.DateMailed = Convert.ToDateTime(dateMailed);
            acknowlwdgement.ALJDecisionNumber = ALJDecisionNo;
            acknowlwdgement.ClaimantName = "test";//claimantName;
            acknowlwdgement.Appellant = appellant;
            SaveAcknowlwdgement(acknowlwdgement);

            return 0;
        }
        public static int WagesAfterAppeal(string text)
        {
            List<string> listOfValues = text.Split("\r\n").ToList();
            var listWithoutWhiteSpace = listOfValues.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            int ssn1 = text.IndexOf("SSN") + 3;
            int ssn2 = text.IndexOf("The claimant stated that");
            var ssnWithCharacter = text.Substring(ssn1, ssn2 - ssn1).Trim();
            var ssn = ssnWithCharacter.Replace(".","").Trim();

            int claimantname1 = text.IndexOf("filed by the claimant") + 21;
            int claimantname2 = text.IndexOf("SSN");
            var claimantnameWithCharacter = text.Substring(claimantname1, claimantname2 - claimantname1).Trim();
            var claimantname = claimantnameWithCharacter.Replace(",", "").Trim();

            int faxNumber1 = text.IndexOf("Fax Number:") + 11;
            int faxNumber2 = text.IndexOf("Fax Number:") + 26;
            var faxNumber = text.Substring(faxNumber1, faxNumber2 - faxNumber1).Trim();

            int telephoneNumber1 = text.IndexOf("Telephone Number") + 18;
            int telephoneNumber2 = text.IndexOf("Telephone Number") + 33;
            var telephoneNumber = text.Substring(telephoneNumber1, telephoneNumber2 - telephoneNumber1).Trim();

            int issueDate1 = text.IndexOf("Issued Date:") + 12;
            int issueDate2 = text.IndexOf("Issued Date:") + 50;
            var issueDateWithSpace = text.Substring(issueDate1, issueDate2 - issueDate1).Trim();
            var issueDateSplitBySpace = issueDateWithSpace.Split("  ");
            var issueDate = issueDateSplitBySpace[0];

            long checkSSN = GetClaimBySSN(ssn);
            if (checkSSN != 0)
            {
                WagesAfterAppeal wagesAppeal = new WagesAfterAppeal();
                wagesAppeal.SocialSecurityNumber = ssn;
                wagesAppeal.ClaimId=checkSSN;
                wagesAppeal.MailingDate = Convert.ToDateTime(issueDate);
                wagesAppeal.FaxNumber = faxNumber;
                wagesAppeal.ClaimantName = claimantname;
                wagesAppeal.TelephoneNumber = telephoneNumber;
                SaveWagesAfterAppeal(wagesAppeal);
            }
            else
            {
                SaveException("This SSN is not available in Claim table");
            }
            return Convert.ToInt32(checkSSN);
        }

        public static int BenefitAudit(string text)
        {
            List<string> listOfValues = text.Split("\r\n").ToList();
            var listWithoutWhiteSpace = listOfValues.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            int employeename1 = text.IndexOf("Employee Name:") + 14;
            int employeename2 = text.IndexOf("Employee Name:") + 44;
            var employeename = text.Substring(employeename1, employeename2 - employeename1).Trim();

            int SSN1 = text.IndexOf("Social Security Number (SSN):") + 30;
            int SSN2 = text.IndexOf("Social Security Number (SSN):") + 42;
            var SSN = text.Substring(SSN1, SSN2 - SSN1).Trim();

            int BYB1 = text.IndexOf("BYB ") + 4;
            int BYB2 = text.IndexOf("BYB ") + 13;
            var BYB = text.Substring(BYB1, BYB2 - BYB1).Trim();

            long checkSSN = GetClaimBySSN(SSN);
            if (checkSSN != 0)
            {
                BenefitAudit benefitAudit = new BenefitAudit();
                benefitAudit.MailDate = Convert.ToDateTime(BYB);
                benefitAudit.SocialSecurityNumber = SSN;
                benefitAudit.ClaimId=checkSSN;
                benefitAudit.ClaimantName = employeename;
                SaveBenefitAudit(benefitAudit);
            }
            else
            {
                SaveException("This SSN is not available in Claim table");
            }
            return Convert.ToInt32(checkSSN);

        }

        public static int NoticeOfWages(string text)
        {

            List<FormIndexMap> formIndex = GetListOfFormDetail("DE1545R");
            List<string> listOfValues = text.Split("\r\n").ToList();
            var listWithoutWhiteSpace = listOfValues.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            var claimantNames = formIndex.Find(x => x.FieldName.Contains("Claimant Name"));
            var trimListOfNameandSSN = listWithoutWhiteSpace[claimantNames.LineNumber].Trim();
            //  var trimListOfNameandSSN = listWithoutWhiteSpace[17].Trim();
            var splitListOfNameandSSN = trimListOfNameandSSN.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            var claimantName = splitListOfNameandSSN[0].Trim();
            var ssn = "042-74-8421";//splitListOfNameandSSN[1].Trim();

            int totalwages1 = text.IndexOf("EMPLOYERS TO ESTABLISH THIS CLAIM") + 33;
            int totalwages2 = text.IndexOf("THE PERCENTAGE");
            var totalwages = text.Substring(totalwages1, totalwages2 - totalwages1).Trim();
            int reservedAmmount1 = text.IndexOf("ACCOUNT IS") + 10;
            int reservedAmmount2 = text.IndexOf("THE CLAIMANT'S WEEKLY");
            var reservedAmmount = text.Substring(reservedAmmount1, reservedAmmount2 - reservedAmmount1).Trim();

            long checkSSN = GetClaimBySSN(ssn);
            if (checkSSN != 0)
            {
                Wages wages = new Wages();
                wages.ClaimantName = claimantName;
                wages.SocialSecurityNumber = ssn;
                wages.ClaimId=checkSSN;
                wages.TotalWagesForAllEmployees = totalwages.Trim();
                wages.BenefitChargeableReserveAccount = reservedAmmount.Trim();
                SaveNoticeOfWages(wages);
            }
            else
            {
                SaveException("This SSN is not available in Claim table");
            }
            return Convert.ToInt32(checkSSN);
        }
        public static int RequestForWages(string text)
        {
            List<string> listOfValues = text.Split("\r\n").ToList();
            var listWithoutWhiteSpace = listOfValues.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            var trimListOfMailDate = listWithoutWhiteSpace[6].Trim();
            var splitListOfMailDate = trimListOfMailDate.Split("    ").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            var mailDate = splitListOfMailDate[0].Trim();
            var caseNumber = splitListOfMailDate[1].Trim();

            var trimFaxNumber = listWithoutWhiteSpace[38].Trim();
            var splitFaxNumber = trimFaxNumber.Split("Fax Number:").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            var faxnumber = splitFaxNumber[1].Trim();

            int claimantName1 = text.IndexOf("Employee Name:") + 14;
            int claimantName2 = text.IndexOf("SSN");
            var claimantName = text.Substring(claimantName1, claimantName2 - claimantName1).Trim();
            int ssn1 = text.IndexOf("SSN:") + 4;
            int ssn2 = text.IndexOf("The employee named");
            var ssn = text.Substring(ssn1, ssn2 - ssn1).Trim();

            int preparerName1 = text.IndexOf("Preparer’s Name:") + 16;
            int preparerName2 = text.IndexOf("Telephone Number");
            var preparerName = text.Substring(preparerName1, preparerName2 - preparerName1).Trim();
            int telephoneNumber1 = text.IndexOf("Telephone Number:") + 16;
            int telephoneNumber2 = text.IndexOf("Fax Number");
            var telephoneNumber = text.Substring(telephoneNumber1, telephoneNumber2 - telephoneNumber1).Trim();
            int deadlinedate1 = text.IndexOf("above by") + 8;
            int deadlinedate2 = text.IndexOf("If this form");
            var deadlinedate = text.Substring(deadlinedate1, deadlinedate2 - deadlinedate1).Trim();

             long checkSSN = GetClaimBySSN(ssn);
            if (checkSSN != 0)
            {

            WagesAfterAppeal wagesAfterAppeal = new WagesAfterAppeal();
            wagesAfterAppeal.ClaimantName = claimantName;
            wagesAfterAppeal.SocialSecurityNumber = ssn;
            wagesAfterAppeal.MailingDate = Convert.ToDateTime(mailDate);
            wagesAfterAppeal.CaseNumber = caseNumber;
            wagesAfterAppeal.ClaimId=checkSSN;
            wagesAfterAppeal.PreparerName = preparerName;
            wagesAfterAppeal.TelephoneNumber = telephoneNumber;
            wagesAfterAppeal.FaxNumber = faxnumber;
            wagesAfterAppeal.DeadLineDate = Convert.ToDateTime(deadlinedate);
            SaveRequestForWages(wagesAfterAppeal);

            }
            else
            {
                SaveException("This SSN is not available in Claim table");
            }
            return Convert.ToInt32(checkSSN);
        }
        public static int SaveClaim(Claim claim)
        {
            int rtn = 0;
            string getSequenceNumber = GetSequenceNumber();
            var getYear = DateTime.Now.Year;
            int benefitYearBeginning = Convert.ToInt32(getYear);
            try
            {
                SqlConnection oraCon = null;
                using (oraCon = new SqlConnection(_SqlConnString))
                {
                    if (_SqlConnString != string.Empty)
                        _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

                    int num = 0;
                    oraCon = new SqlConnection(_SqlConnString);
                    string sSql1 = "insert into CLAIM_TBL (MAIL_DATE,NEW_CLAIM,ADDITIONAL_CLAIM,CLAIMANT_NAME,SOCIAL_SECURITY_NUMBER,EFFECTIVE_DATE_OF_CLAIM,LAST_DATE_WORKED,REASON_FOR_SEPARATION,CLAIMANT_STATUS,CITY,ZIPCODE,ADDRESS,CREATED_ON,BENEFIT_YEAR_BEGINNING,REQUEST_NUMBER) " +
                        "values (@MailDate,@NewClaim,@AdditionalClaim,@ClaimantName,@SocialSecurityNumber,@EffectiveDateOfCalim,@LastDateWorked,@ReasonForSeperation,@ClaimantStatus,@PCity,@PZipcode,@PAddress,@CreatedOn,@BenefitYear,@RequestNumber)";
                    using (SqlCommand sqlCmd = new SqlCommand(sSql1, oraCon))
                    {
                        oraCon.Open();
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.Add(new SqlParameter("MailDate", claim.MailDate));
                        sqlCmd.Parameters.Add(new SqlParameter("NewClaim", claim.NewClaim));
                        sqlCmd.Parameters.Add(new SqlParameter("AdditionalClaim", claim.AdditionalClaim));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimantName", claim.ClaimantName));
                        sqlCmd.Parameters.Add(new SqlParameter("SocialSecurityNumber", claim.SocialSecurityNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("EffectiveDateOfCalim", claim.EffectiveDateOfClaim));
                        sqlCmd.Parameters.Add(new SqlParameter("LastDateWorked", claim.LastDateWorked));
                        sqlCmd.Parameters.Add(new SqlParameter("ReasonForSeperation", claim.ReasonForSeparation));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimantStatus", claim.ClaimantStatus));
                        sqlCmd.Parameters.Add(new SqlParameter("PCity", claim.City));
                        sqlCmd.Parameters.Add(new SqlParameter("PZipcode", claim.Zipcode));
                        sqlCmd.Parameters.Add(new SqlParameter("PAddress", claim.Address));
                        sqlCmd.Parameters.Add(new SqlParameter("CreatedOn", DateTime.Now));
                        sqlCmd.Parameters.Add(new SqlParameter("BenefitYear", benefitYearBeginning));
                        sqlCmd.Parameters.Add(new SqlParameter("RequestNumber", getSequenceNumber));
                        num = sqlCmd.ExecuteNonQuery();
                        oraCon.Close();
                        rtn = GetLastInsertedClaimId();
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }
            return rtn;
        }
        public static string GetSequenceNumber()
        {
            string sequenceNumber = "";
            if (_SqlConnString != string.Empty)
                _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

            if (_SqlConnString != string.Empty)
            {
                SqlConnection oraCon = null;
                try
                {
                    using (oraCon = new SqlConnection(_SqlConnString))
                    {
                        oraCon.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = oraCon;
                        cmd.CommandText = "SELECT NEXT VALUE FOR RequestNumberSequence";
                        cmd.CommandType = CommandType.Text;

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                sequenceNumber = Convert.ToString(dr[0]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _errMsg = ex.Message;
                }
                finally
                {
                    if (oraCon != null)
                        oraCon.Dispose();
                }
            }
            return sequenceNumber;
        }
        public static int GetLastInsertedClaimId()
        {
            int lastInsertedId = 0;
            if (_SqlConnString != string.Empty)
                _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

            if (_SqlConnString != string.Empty)
            {
                SqlConnection oraCon = null;
                try
                {
                    using (oraCon = new SqlConnection(_SqlConnString))
                    {
                        oraCon.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = oraCon;
                        cmd.CommandText = "select MAX(Id) from CLAIM_TBL";
                        cmd.CommandType = CommandType.Text;

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                lastInsertedId = Convert.ToInt32(dr[0]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _errMsg = ex.Message;
                }
                finally
                {
                    if (oraCon != null)
                        oraCon.Dispose();
                }
            }
            return lastInsertedId;
        }

        public static void SaveWagesAfterAppeal(WagesAfterAppeal wagesappeal)
        {
            long claimId = GetWagesAfterAppealBySSN(wagesappeal.SocialSecurityNumber);
            if(wagesappeal.ClaimId != claimId)
            {

            try
            {
                SqlConnection oraCon = null;
                using (oraCon = new SqlConnection(_SqlConnString))
                {
                    if (_SqlConnString != string.Empty)
                        _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

                    int num = 0;
                    oraCon = new SqlConnection(_SqlConnString);
                    string sSql1 = "insert into WAGES_AFTER_APPEAL_TBL (MAILING_DATE,CLAIM_ID,SOCIAL_SECURITY_NUMBER,CLAIMANT_NAME,TELEPHONE_NUMBER,FAX_NUMBER,CREATED_ON) " +
                        "values (@MailDate,@ClaimId,@SocialSecurityNumber,@ClaimantName,@TelephoneNumber,@FaxNumber,@CreatedOn)";
                    using (SqlCommand sqlCmd = new SqlCommand(sSql1, oraCon))
                    {
                        oraCon.Open();
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.Add(new SqlParameter("MailDate", wagesappeal.MailingDate));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimId", wagesappeal.ClaimId));
                        sqlCmd.Parameters.Add(new SqlParameter("SocialSecurityNumber", wagesappeal.SocialSecurityNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimantName", wagesappeal.ClaimantName));
                        sqlCmd.Parameters.Add(new SqlParameter("TelephoneNumber", wagesappeal.TelephoneNumber));                       
                        sqlCmd.Parameters.Add(new SqlParameter("FaxNumber", wagesappeal.FaxNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("CreatedOn", DateTime.Now));
                        num = sqlCmd.ExecuteNonQuery();
                        oraCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }

            }
            else
            {
                SaveException("This form is already exists in current Claim");
            }
        }
        public static void SaveALJDecision(ALJDecision decision)
        {
            long claimId = 0;//GetClaimBySSN(decision.SocialSecurityNumber);
            try
            {
                SqlConnection oraCon = null;
                using (oraCon = new SqlConnection(_SqlConnString))
                {
                    if (_SqlConnString != string.Empty)
                        _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

                    int num = 0;
                    oraCon = new SqlConnection(_SqlConnString);
                    string sSql1 = "insert into ALJ_DECISION_TBL (MAIL_DATE,CLAIM_ID,CASE_NUMBER,FORMERLY_CASE_NUMBER,CLAIMANT_NAME,BYB_CLAIM_DATE,APPLICATION_REOPEN_DATE,EMPLOYER_INFO,ALJ_NAME,PLACE_OF_HEARING_DATE,DECISION,CREATED_ON) " +
                        "values (@MailDate,@ClaimId,@CaseNumber,@FormerlyCaseNumber,@ClaimantName,@BYBClaimDate,@ApplicationReopenDate,@EmployerInfo,@ALJName,@PlaceofHearingDate,@Decisions,@CreatedOn)";
                    using (SqlCommand sqlCmd = new SqlCommand(sSql1, oraCon))
                    {
                        oraCon.Open();
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.Add(new SqlParameter("MailDate", DateTime.Now));  //decision.MailDate
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimId", claimId == 0 ? 2 : claimId));
                        sqlCmd.Parameters.Add(new SqlParameter("CaseNumber", decision.CaseNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("FormerlyCaseNumber", decision.FormerlyCaseNumber==null ?"":decision.FormerlyCaseNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimantName", decision.ClaimantName));
                        sqlCmd.Parameters.Add(new SqlParameter("BYBClaimDate", decision.BYBClaimDate));
                        sqlCmd.Parameters.Add(new SqlParameter("ApplicationReopenDate", DateTime.Now)); //decision.ApplicationReopenDate
                        sqlCmd.Parameters.Add(new SqlParameter("EmployerInfo", decision.EmployerInfo));
                        sqlCmd.Parameters.Add(new SqlParameter("ALJName", decision.ALJName));
                        sqlCmd.Parameters.Add(new SqlParameter("PlaceofHearingDate", decision.HearingDate));
                        sqlCmd.Parameters.Add(new SqlParameter("Decisions", decision.Decision));
                        sqlCmd.Parameters.Add(new SqlParameter("CreatedOn", DateTime.Now));
                        num = sqlCmd.ExecuteNonQuery();
                        oraCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }

        }
        public static void SaveBenefitAudit(BenefitAudit audit)
        {
            long claimId = GetClaimBySSN(audit.SocialSecurityNumber);
            try
            {
                SqlConnection oraCon = null;
                using (oraCon = new SqlConnection(_SqlConnString))
                {
                    if (_SqlConnString != string.Empty)
                        _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

                    int num = 0;
                    oraCon = new SqlConnection(_SqlConnString);
                    string sSql1 = "insert into BENEFIT_AUDIT_TBL (MAIL_DATE,CLAIM_ID,SOCIAL_SECURITY_NUMBER,CLAIMANT_NAME,CREATED_ON) " +
                        "values (@MailDate,@ClaimId,@SocialSecurityNumber,@ClaimantName,@CreatedOn)";
                    using (SqlCommand sqlCmd = new SqlCommand(sSql1, oraCon))
                    {
                        oraCon.Open();
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.Add(new SqlParameter("MailDate", audit.MailDate));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimId", claimId == 0 ? 2 : claimId));
                        sqlCmd.Parameters.Add(new SqlParameter("SocialSecurityNumber", audit.SocialSecurityNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimantName", audit.ClaimantName));
                        sqlCmd.Parameters.Add(new SqlParameter("CreatedOn", DateTime.Now));
                        num = sqlCmd.ExecuteNonQuery();
                        oraCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }

        }
        public static void SaveAdditionalInformation(AdditionalInformation additionalInformation)
        {
            long claimId = GetAdditionalInformationBySSN(additionalInformation.SocialSecurityNumber);
if(additionalInformation.ClaimId != claimId)
{

            try
            {
                SqlConnection oraCon = null;
                using (oraCon = new SqlConnection(_SqlConnString))
                {
                    if (_SqlConnString != string.Empty)
                        _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

                    int num = 0;
                    oraCon = new SqlConnection(_SqlConnString);
                    string sSql1 = "insert into ADDITIONAL_INFORMATION_TBL (MAIL_DATE,CLAIM_ID,SOCIAL_SECURITY_NUMBER,CLAIM_EFFECTIVE_DATE,CLAIMANT_NAME,CONTROL_NUMBER,CREATED_ON) " +
                        "values (@MailDate,@ClaimId,@SocialSecurityNumber,@EffectiveDate,@ClaimantName,@ControlNumber,@CreatedOn)";
                    using (SqlCommand sqlCmd = new SqlCommand(sSql1, oraCon))
                    {
                        oraCon.Open();
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.Add(new SqlParameter("MailDate", additionalInformation.MailDate));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimId", additionalInformation.ClaimId));
                        sqlCmd.Parameters.Add(new SqlParameter("SocialSecurityNumber", additionalInformation.SocialSecurityNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("EffectiveDate", additionalInformation.ClaimEffectiveDate));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimantName", additionalInformation.ClaimantName));
                        sqlCmd.Parameters.Add(new SqlParameter("ControlNumber", additionalInformation.ControlNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("CreatedOn", DateTime.Now));
                        num = sqlCmd.ExecuteNonQuery();
                        oraCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }
            
}
else
{
SaveException("This form is already exists in Current Claim");
}

        }

        public static void SaveAcknowlwdgement(CUIABAcknowledgement acknowledgement)
        {
            long claimId = 0;//GetClaimBySSN(decision.SocialSecurityNumber);
            try
            {
                SqlConnection oraCon = null;
                using (oraCon = new SqlConnection(_SqlConnString))
                {
                    if (_SqlConnString != string.Empty)
                        _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

                    int num = 0;
                    oraCon = new SqlConnection(_SqlConnString);
                    string sSql1 = "insert into CUIAB_ACKNOWLEDGEMENT_TBL (DATE_MAILED,CLAIM_ID,AB_CASE_NUMBER,ALJ_DECISION_NUMBER,CLAIMANT_NAME,CREATED_ON) " +
                        "values (@DateMailed,@ClaimId,@ABCaseNumber,@ALJDecisionNumber,@ClaimantName,@CreatedOn)";
                    using (SqlCommand sqlCmd = new SqlCommand(sSql1, oraCon))
                    {
                        oraCon.Open();
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.Add(new SqlParameter("DateMailed", acknowledgement.DateMailed));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimId", claimId == 0 ? 2 : claimId));
                        sqlCmd.Parameters.Add(new SqlParameter("ABCaseNumber", acknowledgement.ABCaseNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("ALJDecisionNumber", acknowledgement.ALJDecisionNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimantName", acknowledgement.ClaimantName));
                        sqlCmd.Parameters.Add(new SqlParameter("CreatedOn", DateTime.Now));
                        num = sqlCmd.ExecuteNonQuery();
                        oraCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }

        }
        public static void SaveHearing(Hearing hearing)
        {
            long claimId = GetClaimBySSN(hearing.SocialSecurityNumber);
            try
            {
                SqlConnection oraCon = null;
                using (oraCon = new SqlConnection(_SqlConnString))
                {
                    if (_SqlConnString != string.Empty)
                        _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

                    int num = 0;
                    oraCon = new SqlConnection(_SqlConnString);
                    string sSql1 = "insert into NOTICE_OF_HEARING_TBL (HEARING_DATE,CASE_NUMBER,APPELLANT_NAME,CLAIMANT_NAME,CLAIM_ID,EDD_OFFICE,HEARING_PLACE,HEARING_TIME,APPELLANT_TYPE,CREATED_ON) " +
                        "values (@HearingDate,@CaseNumber,@AppellantName,@ClaimantName,@ClaimId,@EDDOffice,@HearingPlace,@HearingTime,@AppellantType,@CreatedOn)";
                    using (SqlCommand sqlCmd = new SqlCommand(sSql1, oraCon))
                    {
                        oraCon.Open();
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.Add(new SqlParameter("HearingDate", hearing.HearingDate));
                        sqlCmd.Parameters.Add(new SqlParameter("CaseNumber", hearing.CaseNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("AppellantName", hearing.AppellantName));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimantName", hearing.ClaimantName));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimId", claimId == 0 ? 2 : claimId));
                        sqlCmd.Parameters.Add(new SqlParameter("EDDOffice", hearing.EDDOffice));
                        sqlCmd.Parameters.Add(new SqlParameter("HearingPlace", hearing.HearingPlace));
                        sqlCmd.Parameters.Add(new SqlParameter("HearingTime", hearing.HearingTime));
                        sqlCmd.Parameters.Add(new SqlParameter("AppellantType", false));
                        sqlCmd.Parameters.Add(new SqlParameter("CreatedOn", DateTime.Now));
                        num = sqlCmd.ExecuteNonQuery();
                        oraCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }

        }
        public static void SaveRequestForWages(WagesAfterAppeal wagesAfterAppeal)
        {
            long claimId = GetClaimBySSN(wagesAfterAppeal.SocialSecurityNumber);
            try
            {
                SqlConnection oraCon = null;
                using (oraCon = new SqlConnection(_SqlConnString))
                {
                    if (_SqlConnString != string.Empty)
                        _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

                    int num = 0;
                    oraCon = new SqlConnection(_SqlConnString);
                    string sSql1 = "insert into WAGES_AFTER_APPEAL_TBL (MAILING_DATE,CASE_NUMBER,SOCIAL_SECURITY_NUMBER,CLAIMANT_NAME,CLAIM_ID,DEADLINE_DATE,PREPARER_NAME,TELEPHONE_NUMBER,FAX_NUMBER,CREATED_ON) " +
                        "values (@MailingDate,@CaseNumber,@SocialSecurityNumber,@ClaimantName,@ClaimId,@DeadLineDate,@PreparerName,@TelephoneNumber,@FaxNumber,@CreatedOn)";
                    using (SqlCommand sqlCmd = new SqlCommand(sSql1, oraCon))
                    {
                        oraCon.Open();
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.Add(new SqlParameter("MailingDate", wagesAfterAppeal.MailingDate));
                        sqlCmd.Parameters.Add(new SqlParameter("CaseNumber", wagesAfterAppeal.CaseNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("SocialSecurityNumber", wagesAfterAppeal.SocialSecurityNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimantName", wagesAfterAppeal.ClaimantName));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimId", claimId == 0 ? 2 : claimId));
                        sqlCmd.Parameters.Add(new SqlParameter("DeadLineDate", wagesAfterAppeal.DeadLineDate));
                        sqlCmd.Parameters.Add(new SqlParameter("PreparerName", wagesAfterAppeal.PreparerName));
                        sqlCmd.Parameters.Add(new SqlParameter("TelephoneNumber", wagesAfterAppeal.TelephoneNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("FaxNumber", wagesAfterAppeal.FaxNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("CreatedOn", DateTime.Now));
                        num = sqlCmd.ExecuteNonQuery();
                        oraCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }

        }
        public static void SaveNoticeOfWages(Wages wages)
        {
            long claimId = GetWagesBySSN(wages.SocialSecurityNumber);
            if(wages.ClaimId !=claimId)
            {

            try
            {
                SqlConnection oraCon = null;
                using (oraCon = new SqlConnection(_SqlConnString))
                {
                    if (_SqlConnString != string.Empty)
                        _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

                    int num = 0;
                    oraCon = new SqlConnection(_SqlConnString);
                    string sSql1 = "insert into WAGES_TBL (BENEFIT_CHARGE_RESERVE_ACC,CLAIM_ID,TOTAL_WAGES_FOR_ALL_EMPLOYEES,SOCIAL_SECURITY_NUMBER,CLAIMANT_NAME,CREATED_ON) " +
                        "values (@ReserveAccount,@ClaimId,@TotalWages,@SocialSecurityNumber,@ClaimantName,@CreatedOn)";
                    using (SqlCommand sqlCmd = new SqlCommand(sSql1, oraCon))
                    {
                        oraCon.Open();
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.Add(new SqlParameter("ReserveAccount", wages.BenefitChargeableReserveAccount));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimId", wages.ClaimId));
                        sqlCmd.Parameters.Add(new SqlParameter("TotalWages", wages.TotalWagesForAllEmployees));
                        sqlCmd.Parameters.Add(new SqlParameter("SocialSecurityNumber", wages.SocialSecurityNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimantName", wages.ClaimantName));
                        sqlCmd.Parameters.Add(new SqlParameter("CreatedOn", DateTime.Now));
                        num = sqlCmd.ExecuteNonQuery();
                        oraCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }
            
            }
            else
            {
SaveException("This Form is already exists in Current claim");
            }

        }
        public static void SaveResponseToEmployer(ResponseToEmployer response)
        {
            long claimId = GetResponseToEmployerCommBySSN(response.SocialSecurityNumber);
           if(response.ClaimId !=claimId)
           {
            try
            {
                SqlConnection oraCon = null;
                using (oraCon = new SqlConnection(_SqlConnString))
                {
                    if (_SqlConnString != string.Empty)
                        _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

                    int num = 0;
                    oraCon = new SqlConnection(_SqlConnString);
                    string sSql1 = "insert into RESPONSE_TO_EMPLOYER_TBL (DATE_MAILED,CLAIM_ID,BENEFIT_YEAR_BEGAN_DATE,CLAIMANT_NAME,SOCIAL_SECURITY_NUMBER,SEPERATION_DATE,CREATED_ON) " +
                        "values (@DateMailed,@ClaimId,@BenefitYearBeganDate,@ClaimantName,@SocialSecurityNumber,@SeperationDate,@CreatedOn)";
                    using (SqlCommand sqlCmd = new SqlCommand(sSql1, oraCon))
                    {
                        oraCon.Open();
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.Add(new SqlParameter("DateMailed", response.DateMailed));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimId", response.ClaimId));
                        sqlCmd.Parameters.Add(new SqlParameter("BenefitYearBeganDate", response.BenefitYearBeganDate));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimantName", response.ClaimantName));
                        sqlCmd.Parameters.Add(new SqlParameter("SocialSecurityNumber", response.SocialSecurityNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("SeperationDate", response.SeperationDate));
                        sqlCmd.Parameters.Add(new SqlParameter("CreatedOn", DateTime.Now));
                        num = sqlCmd.ExecuteNonQuery();
                        oraCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }
            
}
else
{
SaveException("This form is already exists in Current Claim");
}
        }
        public static void SaveRequestForEmployerData(RequestForEmployeeData requestForEmployeeData)
        {
            long claimId = GetClaimBySSN(requestForEmployeeData.SocialSecurityNumber);
            try
            {
                SqlConnection oraCon = null;
                using (oraCon = new SqlConnection(_SqlConnString))
                {
                    if (_SqlConnString != string.Empty)
                        _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

                    int num = 0;
                    oraCon = new SqlConnection(_SqlConnString);
                    string sSql1 = "insert into REQUEST_FOR_EMPLOYEE_DATA_TBL (DATE,CLAIM_ID,BYB_CLAIM_DATE,CLAIMANT_NAME,SOCIAL_SECURITY_NUMBER,USER_COMPLETED_BY,USER_COMPLETED_DATE,USER_TITLE,USER_TELEPHONE_NUMBER,CREATED_ON) " +
                        "values (@PDate,@ClaimId,@BYBClaimDate,@ClaimantName,@SocialSecurityNumber,@UserCompletedBy,@UserCompletedDate,@UserTitle,@UserTelephoneNumber,@CreatedOn)";
                    using (SqlCommand sqlCmd = new SqlCommand(sSql1, oraCon))
                    {
                        oraCon.Open();
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.Add(new SqlParameter("PDate", requestForEmployeeData.Date));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimId", claimId == 0 ? 2 : claimId));
                        sqlCmd.Parameters.Add(new SqlParameter("BYBClaimDate", requestForEmployeeData.BYBClaimDate));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimantName", requestForEmployeeData.ClaimantName));
                        sqlCmd.Parameters.Add(new SqlParameter("SocialSecurityNumber", requestForEmployeeData.SocialSecurityNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("UserCompletedBy", requestForEmployeeData.UserCompletedBy));
                        sqlCmd.Parameters.Add(new SqlParameter("UserCompletedDate", DateTime.Now));  //requestForEmployeeData.UserCompletedDate
                        sqlCmd.Parameters.Add(new SqlParameter("UserTitle", requestForEmployeeData.UserTitle));
                        sqlCmd.Parameters.Add(new SqlParameter("UserTelephoneNumber", requestForEmployeeData.UserTelephoneNumber));
                        sqlCmd.Parameters.Add(new SqlParameter("CreatedOn", DateTime.Now));
                        num = sqlCmd.ExecuteNonQuery();
                        oraCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }
        }
        public static void SaveCalimDetermination(ClaimDetermination determination)
        {
                long claimId = GetNoticeOfDeterminationBySSN(determination.SocialSecurityNumber);
                if(determination.ClaimId != claimId)
                {
                   try
                   {
                       SqlConnection oraCon = null;
                       using (oraCon = new SqlConnection(_SqlConnString))
                       {
                           if (_SqlConnString != string.Empty)
                               _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
       
                           int num = 0;
                           oraCon = new SqlConnection(_SqlConnString);
                           string sSql1 = "insert into CLAIM_DETERMINATION_TBL (MAILED_DATE,CLAIM_ID,BENEFIT_YEAR_BEGAN,FIELD_OFFICE,SOCIAL_SECURITY_NUMBER,CREATED_ON) " +
                               "values (@DateMailed,@ClaimId,@BenefitYearBeganDate,@FieldOffice,@SocialSecurityNumber,@CreatedOn)";
                           using (SqlCommand sqlCmd = new SqlCommand(sSql1, oraCon))
                           {
                               oraCon.Open();
                               sqlCmd.CommandType = CommandType.Text;
                               sqlCmd.Parameters.Add(new SqlParameter("DateMailed", determination.MailedDate));
                               sqlCmd.Parameters.Add(new SqlParameter("ClaimId", determination.ClaimId));
                               sqlCmd.Parameters.Add(new SqlParameter("BenefitYearBeganDate", determination.BenefitYearBegan));
                               sqlCmd.Parameters.Add(new SqlParameter("FieldOffice", determination.FieldOffice));
                               sqlCmd.Parameters.Add(new SqlParameter("SocialSecurityNumber", determination.SocialSecurityNumber));
                               sqlCmd.Parameters.Add(new SqlParameter("CreatedOn", DateTime.Now));
                               num = sqlCmd.ExecuteNonQuery();                        
                               oraCon.Close();
                           }
                       }
       
                    }
        
                    catch (Exception ex)
                    {
                        _errMsg = ex.Message;
                    }
                }
                else
                {
                    SaveException("This document is already exists for this Claim");
                }
        }
        public static void SaveException(string reason)
        {
            try
            {
                SqlConnection oraCon = null;
                using (oraCon = new SqlConnection(_SqlConnString))
                {
                    if (_SqlConnString != string.Empty)
                        _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

                    int num = 0;
                    oraCon = new SqlConnection(_SqlConnString);
                    string sSql1 = "insert into CLAIM_EXCEPTION_TBL (EXCEPTION_REASON,EXCEPTION_DATE,CREATED_ON) " +
                        "values (@ExceptionReason,@ExceptionDate,@CreatedOn)";
                    using (SqlCommand sqlCmd = new SqlCommand(sSql1, oraCon))
                    {
                        oraCon.Open();
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.Add(new SqlParameter("ExceptionReason", reason));
                        sqlCmd.Parameters.Add(new SqlParameter("ExceptionDate", DateTime.Now));
                        sqlCmd.Parameters.Add(new SqlParameter("CreatedOn", DateTime.Now));
                        num = sqlCmd.ExecuteNonQuery();
                        oraCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }
        }
        public static MDDocument GetDocumentDetailByCode(string code)
        {
            MDDocument document = new MDDocument();
            if (_SqlConnString != string.Empty)
                _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

            if (_SqlConnString != string.Empty)
            {
                SqlConnection oraCon = null;
                try
                {
                    using (oraCon = new SqlConnection(_SqlConnString))
                    {
                        oraCon.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = oraCon;
                        cmd.CommandText = "Select * from MD_DOCUMENT_TBL where DOCUMENT_NAME='" + code + "' and DOCUMENT_STATUS='Active'";
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                document = (new MDDocument
                                {
                                    Id = dr["Id"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Id"]),
                                    DocumentName = dr["DOCUMENT_NAME"] == DBNull.Value ? string.Empty : Convert.ToString(dr["DOCUMENT_NAME"]),
                                    DocumentDescription = dr["DOCUMENT_DESCRIPTION"] == DBNull.Value ? string.Empty : Convert.ToString(dr["DOCUMENT_DESCRIPTION"]),

                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _errMsg = ex.Message;
                }
                finally
                {
                    if (oraCon != null)
                        oraCon.Dispose();
                }
            }
            return document;

        }
        public static List<FormIndexMap> GetListOfFormDetail(string code)
        {
            List<FormIndexMap> formIndexMap = new List<FormIndexMap>();
            if (_SqlConnString != string.Empty)
                _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

            if (_SqlConnString != string.Empty)
            {
                SqlConnection oraCon = null;
                try
                {
                    using (oraCon = new SqlConnection(_SqlConnString))
                    {
                        oraCon.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = oraCon;
                        cmd.CommandText = "Select * from FORM_INDEX_MAPPING_TBL where FORM_CODE='" + code + "' and STATUS='Active'";
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                formIndexMap.Add(new FormIndexMap
                                {
                                    LineNumber = dr["LINE_NUMBER"] == DBNull.Value ? 0 : Convert.ToInt32(dr["LINE_NUMBER"]),
                                    Formcode = dr["FORM_CODE"] == DBNull.Value ? string.Empty : Convert.ToString(dr["FORM_CODE"]),
                                    FieldName = dr["FIELD_NAME"] == DBNull.Value ? string.Empty : Convert.ToString(dr["FIELD_NAME"]),
                                    PositionTopLeft = dr["POSITION_TOP_LEFT"] == DBNull.Value ? string.Empty : Convert.ToString(dr["POSITION_TOP_LEFT"]),
                                    PositionBottomRight = dr["POSITION_BOTTOM_RIGHT"] == DBNull.Value ? string.Empty : Convert.ToString(dr["POSITION_BOTTOM_RIGHT"]),

                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _errMsg = ex.Message;
                }
                finally
                {
                    if (oraCon != null)
                        oraCon.Dispose();
                }
            }
            return formIndexMap;

        }
        public static Employee GetEmployeeDetailByEmpNo(string EmpNo)
        {
            Employee employee = new Employee();
            if (_SqlConnString != string.Empty)
                _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

            if (_SqlConnString != string.Empty)
            {
                SqlConnection oraCon = null;
                try
                {
                    using (oraCon = new SqlConnection(_SqlConnString))
                    {
                        oraCon.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = oraCon;
                        cmd.CommandText = "Select * from EMPLOYEE_TBL where EMP_NUM_CODE='" + EmpNo + "'";
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                employee = (new Employee
                                {
                                    EmployeeNumber = dr["EMP_NUM_CODE"] == DBNull.Value ? string.Empty : Convert.ToString(dr["EMP_NUM_CODE"]),
                                    FirstName = dr["FIRST_NAME"] == DBNull.Value ? string.Empty : Convert.ToString(dr["FIRST_NAME"]),
                                    LastName = dr["LAST_NAME"] == DBNull.Value ? string.Empty : Convert.ToString(dr["LAST_NAME"]),
                                    SAPEmailAddress = dr["SAP_EMAIL_ADDRESS"] == DBNull.Value ? string.Empty : Convert.ToString(dr["SAP_EMAIL_ADDRESS"]),

                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _errMsg = ex.Message;
                }
                finally
                {
                    if (oraCon != null)
                        oraCon.Dispose();
                }
            }
            return employee;

        }
        public static SAP GetSAPDetailBySSN(string ssn)
        {
            SAP sap = new SAP();
            if (_SqlConnString != string.Empty)
                _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

            if (_SqlConnString != string.Empty)
            {
                SqlConnection oraCon = null;
                try
                {
                    using (oraCon = new SqlConnection(_SqlConnString))
                    {
                        oraCon.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = oraCon;
                        cmd.CommandText = "Select * from SAP_TBL where SOCIAL_SECURITY_NUMBER='" + ssn + "'";
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                sap = (new SAP
                                {

                                    EmployeeNumber = dr["EMPLOYEE_NUMBER"] == DBNull.Value ? string.Empty : Convert.ToString(dr["EMPLOYEE_NUMBER"]),
                                    SocialSecurityNumber = dr["SOCIAL_SECURITY_NUMBER"] == DBNull.Value ? string.Empty : Convert.ToString(dr["SOCIAL_SECURITY_NUMBER"]),

                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _errMsg = ex.Message;
                }
                finally
                {
                    if (oraCon != null)
                        oraCon.Dispose();
                }
            }
            return sap;

        }
        public static void SaveDocumentMapping(int claimId, string documentcode, Guid guid)
        {
            MDDocument getDocumentDetail = GetDocumentDetailByCode(documentcode);
            try
            {
                SqlConnection oraCon = null;
                using (oraCon = new SqlConnection(_SqlConnString))
                {
                    if (_SqlConnString != string.Empty)
                        _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

                    int num = 0;
                    oraCon = new SqlConnection(_SqlConnString);
                    string sSql1 = "insert into FORM_DOCUMENT_MAP_TBL (DOCUMENT_ID,CLAIM_ID,SAVE_FILE_GUID,RECEIVED_DATE,DOCUMENT_TYPE,DOCUMENT_NAME,IS_SHAREPOINT_PUSHED,CREATED_ON) " +
                        "values (@DocumentId,@ClaimId,@SaveFileGuid,@ReceivedDate,@DocumentType,@DocumentName,@IsSharePointPushed,@CreatedOn)";
                    using (SqlCommand sqlCmd = new SqlCommand(sSql1, oraCon))
                    {
                        oraCon.Open();
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.Add(new SqlParameter("DocumentId", getDocumentDetail.Id));
                        sqlCmd.Parameters.Add(new SqlParameter("ClaimId", claimId));
                        sqlCmd.Parameters.Add(new SqlParameter("SaveFileGuid", guid.ToString()));
                        sqlCmd.Parameters.Add(new SqlParameter("ReceivedDate", DateTime.Now));
                        sqlCmd.Parameters.Add(new SqlParameter("DocumentType", getDocumentDetail.DocumentName));
                        sqlCmd.Parameters.Add(new SqlParameter("DocumentName", getDocumentDetail.DocumentDescription));
                        sqlCmd.Parameters.Add(new SqlParameter("IsSharePointPushed", false));
                        sqlCmd.Parameters.Add(new SqlParameter("CreatedOn", DateTime.Now));
                        num = sqlCmd.ExecuteNonQuery();
                        oraCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }
        }
        public static void SaveSAPDetail(string ssnNumber)
        {
            try
            {
                SqlConnection oraCon = null;
                using (oraCon = new SqlConnection(_SqlConnString))
                {
                    if (_SqlConnString != string.Empty)
                        _SqlConnString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

                  //  int num = 0;
                    oraCon = new SqlConnection(_SqlConnString);
                    string sSql1 = "insert into SAP_TBL (SOCIAL_SECURITY_NUMBER) " +
                        "values (@ssnnumber)";
                    using (SqlCommand sqlCmd = new SqlCommand(sSql1, oraCon))
                    {
                        oraCon.Open();
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.Add(new SqlParameter("ssnnumber", ssnNumber));
                        oraCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }
        }
        public  void OCRExtractionJob()
        {
            // DirectoryInfo directory = new DirectoryInfo(ConfigurationManager.AppSettings["InboundPath"].ToString());
            // FileInfo[] allFiles = directory.GetFiles();
            // var listOfAllFiles = allFiles.ToList();
            // //  var listOfCurrentDayFiles = listOfAllFiles.Where(x => (x.CreationTime.Date.ToString("dd/MM/yyyy") == DateTime.Today.Date.ToString("dd/MM/yyyy")) || (x.LastWriteTime.Date.ToString("dd/MM/yyyy") == DateTime.Today.Date.ToString("dd/MM/yyyy"))).ToList();           
            // foreach (var files in listOfAllFiles)
            // {
            //     if (files.Extension == ".txt" || files.Extension == ".pdf" || files.Extension == ".jpeg" || files.Extension == ".jpg" || files.Extension == ".png")
            //     {
            //         var textFromFile = File.ReadAllText(files.FullName);
            //         var formName = StartOCRProcess(textFromFile);

            //         if (formName.Contains("ExceptionForm"))
            //         {
            //             var saveRootPath = ConfigurationManager.AppSettings["ExceptionPath"].ToString();
            //             Guid guid = Guid.NewGuid();
            //             var file = System.IO.Path.Combine(saveRootPath, guid + ".pdf");
            //             System.IO.File.WriteAllText(file, textFromFile);
            //             SaveException("The form code is not matching");
            //         }
            //         else
            //         {
            //             var saveRootPath = ConfigurationManager.AppSettings["ProcessPath"].ToString();
            //             var splitClaimId = formName.Split("_");
            //             int claimID = Convert.ToInt32(splitClaimId[0]);
            //             var documentCode = splitClaimId[1];
            //             if(documentCode !="DatasIncorrect")
            //             { 
            //             Guid guid = Guid.NewGuid();
            //             var file = System.IO.Path.Combine(saveRootPath, guid + ".pdf");
            //             System.IO.File.WriteAllText(file, textFromFile);                       
            //             SaveDocumentMapping(claimID, documentCode, guid);
            //             }
            //             else
            //             {
            //                 Guid guid = Guid.NewGuid();
            //                 var file = System.IO.Path.Combine(ConfigurationManager.AppSettings["ExceptionPath"].ToString(), guid + ".pdf");
            //                 System.IO.File.WriteAllText(file, textFromFile);    
            //             }
            //         }
            //         File.Delete(files.FullName);
            //     }
            //     else
            //     {
            //         SaveException("The file type is not valid");
            //     }

            // }

          Main();
        }
      

    }
}

