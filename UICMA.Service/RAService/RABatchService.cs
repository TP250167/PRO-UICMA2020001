using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using UICMA.Domain.Entities;
using UICMA.Domain.Entities.Employees;
using UICMA.Domain.Entities.Notifications;
using UICMA.Domain.Entities.RA.RAView;
using UICMA.Domain.Entities.RABatchRecipientMap;
using UICMA.Domain.Entities.RABatchRecipientRules;
using UICMA.Domain.Entities.RABatchRecipients;
using UICMA.Domain.Entities.RABatchs;
using UICMA.Domain.Entities.RABatchSchedules;
using UICMA.Domain.Entities.RARecipients;
using UICMA.Domain.Entities.RASchedules;
using UICMA.Domain.Entities.Templates;
using UICMA.Repository.ClaimRepository;
using UICMA.Repository.RARepository;
using Spire.Xls;
using System.Linq;

namespace UICMA.Service.RAService
{
    public class RABatchService : IRABatchService
    {
        private IRABatchRepository _RABatchRepository;

        private IRAScheduleRepository _RAScheduleRepository;
        private IRABatchScheduleRepository _RABatchScheduleRepository;
        private IEmployeeInfoDataRepository _EmployeeInfoDataRepository;
        private IRARecipientRepository _RARecipientRepository;
        private ITemplateRepository _TemplateRepository;
        private IRABatchRecipientRepository _RABatchRecipientRepository;
        private INotificationRepository _NotificationRepository;
        private IRABatchRecipientRuleRepository _RABatchRecipientRuleRepository;
        private IRARecipientRuleRepository _RARecipientRuleRepository;
        private string _FromMail;
        private IHostingEnvironment _hostingEnvironment;


        public RABatchService(IRABatchRepository _RABatchRepository, IRAScheduleRepository _RAScheduleRepository, IRABatchScheduleRepository _RABatchScheduleRepository, IEmployeeInfoDataRepository _EmployeeInfoDataRepository, IRARecipientRepository _RARecipientRepository,
            ITemplateRepository _TemplateRepository, IRABatchRecipientRepository _RABatchRecipientRepository, INotificationRepository _NotificationRepository, IRABatchRecipientRuleRepository _RABatchRecipientRuleRepository, IRARecipientRuleRepository _RARecipientRuleRepository,
             IConfiguration configuration, IHostingEnvironment _hostingEnvironment)
        {
            this._RABatchRepository = _RABatchRepository;
            this._RAScheduleRepository = _RAScheduleRepository;
            this._RABatchScheduleRepository = _RABatchScheduleRepository;
            this._EmployeeInfoDataRepository = _EmployeeInfoDataRepository;
            this._RARecipientRepository = _RARecipientRepository;
            this._TemplateRepository= _TemplateRepository;
            this._RABatchRecipientRepository = _RABatchRecipientRepository;
            this._NotificationRepository = _NotificationRepository;
            this._RABatchRecipientRuleRepository = _RABatchRecipientRuleRepository;
            this._RARecipientRuleRepository =_RARecipientRuleRepository;
            _FromMail = configuration.GetSection("FromMail").Value;
            this._hostingEnvironment= _hostingEnvironment;
        }
        

        //Add and Update RABatch
        public RABatchView CreateBatch(RABatchView Batch)
        {

            RABatchView oBatch = new RABatchView();
            RASchedule rASchedule = new RASchedule();
            int Recipientcount = 0;

            //Custom Upload
            if (Batch.Id == 0 && Batch.isAnnual == false  && Batch.IsCustom == true)
            {
                Batch.Status = "Active";
                Batch.IsRecuring = false;
                Batch.IsCustom = true;
                Batch.CreatedOn = DateTime.Now;
                oBatch = _RABatchRepository.AddData(Batch);

                var web = _hostingEnvironment.ContentRootPath;
                var webpath = Path.Combine(web, "Custom Batch Upload");
                var csvpath = "";
                if (Batch.filetype == "csv")
                {
                    var Csv_File_name = Guid.NewGuid().ToString("N") + ".csv";
                    csvpath = Path.Combine(webpath, Csv_File_name);
                    var subpath = Path.Combine(webpath);
                    string File = Batch.uploadExcel;
                    byte[] contents = Convert.FromBase64String(File);
                    bool exists = System.IO.Directory.Exists(subpath);
                    if (!exists)
                    {
                        System.IO.Directory.CreateDirectory(subpath);
                    }
                    var path = Path.Combine(subpath, Path.GetFileName(Csv_File_name));
                    System.IO.File.WriteAllBytes(path, contents);
                }
                else
                {
                    // var rootpath = _hostingEnvironment.WebRootPath;
                    var newGuid = Guid.NewGuid().ToString("N");
                    var File_name = newGuid + ".xlsx";
                    var resultpath = Path.Combine(webpath, File_name);
                    var subpath = Path.Combine(webpath);
                    string File = Batch.uploadExcel;
                    byte[] contents = Convert.FromBase64String(File);
                    bool exists = System.IO.Directory.Exists(subpath);
                    if (!exists)
                    {
                        System.IO.Directory.CreateDirectory(subpath);
                    }
                    var path = Path.Combine(subpath, Path.GetFileName(File_name));
                    System.IO.File.WriteAllBytes(path, contents);

                    var Csv_File_name = newGuid + ".csv";
                    csvpath = Path.Combine(webpath, Csv_File_name);

                    Spire.Xls.Workbook workbook = new Spire.Xls.Workbook();
                    workbook.LoadFromFile(resultpath);
                    Spire.Xls.Worksheet sheet = workbook.Worksheets[0];
                    sheet.SaveToFile(csvpath, ",", Encoding.UTF8);
                }

                DataTable tblcsv = new DataTable();
                tblcsv.Columns.Add("EmployeeNumber");
                tblcsv.Columns.Add("EmployeeEmail");
                tblcsv.Columns.Add("EmployeeName");

                string CSVFilePath = csvpath;
                string ReadCSV = System.IO.File.ReadAllText(CSVFilePath);
                var replaeSpace = ReadCSV.Trim();
                var exactColumnWithHeader = replaeSpace.Split(new[] { "\n", "\r\n" }, StringSplitOptions.None);
                var exactColumn = exactColumnWithHeader.ToList();
                exactColumn.RemoveAt(0);
                //spliting row after new line 
                foreach (string csvRow in exactColumn)
                {
                    int count = 0;
                    DataRow dr = tblcsv.NewRow();
                    dr["EmployeeName"] = csvRow.Split(',')[0].Replace("\"", "");
                    dr["EmployeeNumber"] = csvRow.Split(',')[0].Replace("\"", "");
                    dr["EmployeeEmail"] = csvRow.Split(',')[1].Replace("\"", "");
                    tblcsv.Rows.Add(dr);
                    count++;
                }
                //tblcsv.Rows.Remove(tblcsv.Rows[0]);

                var convertedList = (from rw in tblcsv.AsEnumerable()
                                     select new RARecipient()
                                     {
                                         EmployeeName = Convert.ToString(rw["EmployeeName"]),
                                         EmployeeNumber = Convert.ToString(rw["EmployeeNumber"]),
                                         EmployeeEmail = Convert.ToString(rw["EmployeeEmail"]),
                                         // CreatedOn = DateTime.Now                                        
                                     }).ToList();
                Recipientcount += convertedList.Count;
                if (convertedList.Count != 0)
                {
                    foreach (var employee in convertedList)
                    {
                        RARecipient recipient = new RARecipient();
                        recipient.EmployeeName = employee.EmployeeName;
                        recipient.EmployeeEmail = employee.EmployeeEmail;
                        recipient.EmployeeNumber = employee.EmployeeNumber;
                        recipient.Status = "Active";
                        recipient.CreatedOn = DateTime.Now;
                        var addrecipient = _RARecipientRepository.AddData(recipient);
                        RABatchRecipient raBatchRecipientMap = new RABatchRecipient();
                        raBatchRecipientMap.BatchId = oBatch.Id;
                        raBatchRecipientMap.RecipientId = recipient.Id;
                        var AddraBatchRecipientMap = _RABatchRecipientRepository.AddData(raBatchRecipientMap);
                        //Template
                        Template temp = _TemplateRepository.GetSingle(Batch.TemplateID);
                        Notification notify = new Notification();
                        notify.CreatedOn = DateTime.Now;
                        notify.EmployeeNumber = employee.EmployeeName;
                        notify.NotifyTo = employee.EmployeeEmail;
                        notify.NotifySubject = Batch.BatchName;
                        notify.NotifyFrom = _FromMail;
                        notify.NotifyStatus = "To Email";
                        notify.NotifyBody = temp.TemplateBodyContent;
                        notify.RequestType = "Email";
                        notify.NotifyAttachment = temp.TemplateAttachmentContent;

                        var AddNotifation = _NotificationRepository.AddData(notify);
                    }
                }
            }
            //Annual Batch Creation
            if (Batch.Id == 0 && Batch.isAnnual==true)
            {
                //Add RABatch
                DateTime today = DateTime.Now;
                Batch.CreatedOn= DateTime.Now;
                DateTime NextOccuranceDate = DateTime.Now.AddYears(1);
                Batch.NextOccurrance = NextOccuranceDate;               
                Batch.Status = "Active";
                Batch.IsRecuring = true;
                Batch.Frequency = "Yearly";
                oBatch = _RABatchRepository.AddData(Batch);                 
                //Add RASchedule
                rASchedule.ScheduleDate = Batch.RASchedule.ScheduleDate;
                rASchedule.Status = "Active";
                rASchedule.CreatedBy = Batch.CreatedBy;
                rASchedule.CreatedOn = DateTime.Now;
                //Add RAScheduleMap
                RABatchSchedule rABatchSchedule = new RABatchSchedule();
                rABatchSchedule.BatchId = oBatch.Id;
                List<Employee> Emp = new List<Employee>();             
                rASchedule = _RAScheduleRepository.AddData(rASchedule);
                rABatchSchedule.RAScheduleId = rASchedule.Id;
                rABatchSchedule = _RABatchScheduleRepository.AddData(rABatchSchedule);
                var  Rules = Batch.RAbatchRecRule.RecipientRuleListId.Split(",");
                foreach (var recp in Rules)
                {              
                RABatchRecipientRule rARecipientRule = new RABatchRecipientRule();
                rARecipientRule.BatchId= oBatch.Id;
                rARecipientRule.RecipientRuleId = Convert.ToInt32(recp);
                rARecipientRule = _RABatchRecipientRuleRepository.AddData(rARecipientRule);
                    var Rule = _RARecipientRuleRepository.GetSingle(Convert.ToInt32(recp));                              
                switch (Rule.RecipientRuleName)
                {
                    case "1":
                        Emp = _EmployeeInfoDataRepository.GetClassifiedEmployee();
                        Recipientcount +=  Emp.Count;                      
                        if (Emp.Count != 0)
                        {
                            foreach (var employee in Emp)
                            {                             
                                RARecipient recipient = new RARecipient();
                                recipient.EmployeeName = employee.FirstName + " " +employee.LastName;
                                recipient.EmployeeEmail = employee.OIDEmailAddress;
                                recipient.EmployeeNumber = employee.EmployeeNumberCode;
                                recipient.Status ="Active";
                                recipient.CreatedOn = DateTime.Now;
                                var addrecipient = _RARecipientRepository.AddData(recipient);                               
                                RABatchRecipient raBatchRecipientMap = new RABatchRecipient();
                                raBatchRecipientMap.BatchId= oBatch.Id;
                                raBatchRecipientMap.RecipientId = recipient.Id;
                               var  AddraBatchRecipientMap = _RABatchRecipientRepository.AddData(raBatchRecipientMap);
                                    //Template
                                    Template temp = _TemplateRepository.GetSingle(Batch.TemplateID);
                                Notification notify = new Notification();
                                    notify.CreatedOn = DateTime.Now;
                                    notify.EmployeeNumber = employee.EmployeeNumberCode;
                                notify.NotifyTo = employee.OIDEmailAddress;
                                notify.NotifySubject = Batch.BatchName;
                                notify.NotifyFrom = _FromMail;
                                notify.NotifyStatus = "To Email";
                                notify.NotifyBody = temp.TemplateBodyContent;
                                notify.RequestType = "Email";
                                notify.NotifyAttachment = temp.TemplateAttachmentContent;

                                    var AddNotifation = _NotificationRepository.AddData(notify);                               
                            }
                        }
                        break;

                    case "3 EXCEPT  3Y":
                        Emp = _EmployeeInfoDataRepository.GetUnclassifiedEmployee();
                        Recipientcount += Emp.Count;
                        if (Emp.Count != 0)
                        {
                            foreach (var employee in Emp)
                            {
                                RARecipient recipient = new RARecipient();
                                recipient.EmployeeName = employee.FirstName + " " + employee.LastName;
                                recipient.EmployeeEmail = employee.OIDEmailAddress;
                                recipient.EmployeeNumber = employee.EmployeeNumberCode;
                                recipient.Status = "Active";
                                recipient.CreatedOn = DateTime.Now;
                                var addrecipient = _RARecipientRepository.AddData(recipient);
                                RABatchRecipient raBatchRecipientMap = new RABatchRecipient();
                                raBatchRecipientMap.BatchId = oBatch.Id;
                                raBatchRecipientMap.RecipientId = recipient.Id;
                                var AddraBatchRecipientMap = _RABatchRecipientRepository.AddData(raBatchRecipientMap);
                                    
                                    Template temp = _TemplateRepository.GetSingle(Batch.TemplateID);
                                    Notification notify = new Notification();
                                    notify.CreatedOn = DateTime.Now;
                                    notify.EmployeeNumber = employee.EmployeeNumberCode;
                                notify.NotifyTo = employee.OIDEmailAddress;
                                notify.NotifySubject = Batch.BatchName;
                                notify.NotifyFrom = _FromMail;
                                notify.NotifyStatus = "To Email";
                                notify.NotifyBody = temp.TemplateBodyContent;
                                notify.RequestType = "Email";
                                var AddNotifation = _NotificationRepository.AddData(notify);
                            }
                        }
                        break;
                    case "2F":
                        Emp = _EmployeeInfoDataRepository.GetTeacherAssitantEmployee();
                        Recipientcount+= Emp.Count;                     
                        if (Emp.Count != 0)
                        {
                            foreach (var employee in Emp)
                            {
                                RARecipient recipient = new RARecipient();
                                recipient.EmployeeName = employee.FirstName + " " + employee.LastName;
                                recipient.EmployeeEmail = employee.OIDEmailAddress;
                                recipient.EmployeeNumber = employee.EmployeeNumberCode;
                                recipient.Status = "Active";
                                recipient.CreatedOn = DateTime.Now;
                                var addrecipient = _RARecipientRepository.AddData(recipient);
                                RABatchRecipient raBatchRecipientMap = new RABatchRecipient();
                                raBatchRecipientMap.BatchId = oBatch.Id;
                                raBatchRecipientMap.RecipientId = recipient.Id;
                                var AddraBatchRecipientMap = _RABatchRecipientRepository.AddData(raBatchRecipientMap);
                                    
                                    Template temp = _TemplateRepository.GetSingle(Batch.TemplateID);
                                    Notification notify = new Notification();
                                    notify.CreatedOn = DateTime.Now;
                                    notify.EmployeeNumber = employee.EmployeeNumberCode;
                                notify.NotifyTo = employee.OIDEmailAddress;
                                notify.NotifySubject = Batch.BatchName;
                                notify.NotifyFrom = _FromMail;
                                notify.NotifyStatus = "To Email";
                                notify.NotifyBody = temp.TemplateBodyContent;
                                notify.RequestType = "Email";
                                var AddNotifation = _NotificationRepository.AddData(notify);
                            }
                        }
                        break;
                    case "2UTK":
                        Emp = _EmployeeInfoDataRepository.GetSpecialEducation();
                        Recipientcount+= Emp.Count;                      
                        if (Emp.Count != 0)
                        {
                            foreach (var employee in Emp)
                            {
                                RARecipient recipient = new RARecipient();
                                recipient.EmployeeName = employee.FirstName + " " + employee.LastName;
                                recipient.EmployeeEmail = employee.OIDEmailAddress;
                                recipient.EmployeeNumber = employee.EmployeeNumberCode;
                                recipient.Status = "Active";
                                recipient.CreatedOn = DateTime.Now;
                                var addrecipient = _RARecipientRepository.AddData(recipient);
                                RABatchRecipient raBatchRecipientMap = new RABatchRecipient();
                                raBatchRecipientMap.BatchId = oBatch.Id;
                                raBatchRecipientMap.RecipientId = recipient.Id;
                                var AddraBatchRecipientMap = _RABatchRecipientRepository.AddData(raBatchRecipientMap);
                                    
                                    Template temp = _TemplateRepository.GetSingle(Batch.TemplateID);
                                    Notification notify = new Notification();
                                    notify.CreatedOn = DateTime.Now;
                                    notify.EmployeeNumber = employee.EmployeeNumberCode;
                                notify.NotifyTo = employee.OIDEmailAddress;
                                notify.NotifySubject = Batch.BatchName;
                                notify.NotifyFrom = _FromMail;
                                notify.NotifyStatus = "To Email";
                                notify.NotifyBody = temp.TemplateBodyContent;
                                notify.RequestType = "Email";
                                var AddNotifation = _NotificationRepository.AddData(notify);
                            }
                        }
                        break;
                    case "2USX AND 2UTH AND 2UTE":
                        Emp = _EmployeeInfoDataRepository.GetSupportSchool();
                        Recipientcount += Emp.Count;
                       
                        if (Emp.Count != 0)
                        {
                            foreach (var employee in Emp)
                            {
                                RARecipient recipient = new RARecipient();
                                recipient.EmployeeName = employee.FirstName + " " + employee.LastName;
                                recipient.EmployeeEmail = employee.OIDEmailAddress;
                                recipient.EmployeeNumber = employee.EmployeeNumberCode;
                                recipient.Status = "Active";
                                recipient.CreatedOn = DateTime.Now;
                                var addrecipient = _RARecipientRepository.AddData(recipient);
                                RABatchRecipient raBatchRecipientMap = new RABatchRecipient();
                                raBatchRecipientMap.BatchId = oBatch.Id;
                                raBatchRecipientMap.RecipientId = recipient.Id;
                                var AddraBatchRecipientMap = _RABatchRecipientRepository.AddData(raBatchRecipientMap);
                                   
                                    Template temp = _TemplateRepository.GetSingle(Batch.TemplateID);
                                    Notification notify = new Notification();
                                    notify.CreatedOn = DateTime.Now;
                                    notify.EmployeeNumber = employee.EmployeeNumberCode;
                                notify.NotifyTo = employee.OIDEmailAddress;
                                notify.NotifySubject = Batch.BatchName;
                                notify.NotifyFrom = _FromMail;
                                notify.NotifyStatus = "To Email";
                                notify.NotifyBody = temp.TemplateBodyContent;
                                notify.RequestType = "Email";
                                var AddNotifation = _NotificationRepository.AddData(notify);
                            }
                        }
                        break;                  
                }

                }
                rASchedule.TotalRecipient = Recipientcount;
                rASchedule = _RAScheduleRepository.UpdateData(rASchedule);             
            }
            //Weekly Batch Creation
            if (Batch.Id == 0 && Batch.isAnnual==false)
            {
                //Add RABatch
                DateTime today = DateTime.Now;
                DateTime NextOccuranceDate = today.AddDays(15);
                Batch.NextOccurrance = NextOccuranceDate;
                Batch.CreatedOn = DateTime.Now;
                Batch.Status = "Active";
                Batch.IsRecuring = true;
                Batch.Frequency = "Weekly";
                oBatch = _RABatchRepository.AddData(Batch);
                //Add RASchedule
                rASchedule.ScheduleDate = Batch.RASchedule.ScheduleDate;
                rASchedule.Status = "Active";
                rASchedule.CreatedBy = Batch.CreatedBy;
                rASchedule.CreatedOn = DateTime.Now;
                //Add RAScheduleMap
                RABatchSchedule rABatchSchedule = new RABatchSchedule();
                rABatchSchedule.BatchId = oBatch.Id;
                List<Employee> Emp = new List<Employee>();
                rASchedule = _RAScheduleRepository.AddData(rASchedule);
                rABatchSchedule.RAScheduleId = rASchedule.Id;
                rABatchSchedule = _RABatchScheduleRepository.AddData(rABatchSchedule);
                var Rules = Batch.RAbatchRecRule.RecipientRuleListId.Split(",");
                foreach (var recp in Rules)
                {
                    RABatchRecipientRule rARecipientRule = new RABatchRecipientRule();
                    rARecipientRule.BatchId = oBatch.Id;
                    rARecipientRule.RecipientRuleId = Convert.ToInt32(recp);
                    rARecipientRule = _RABatchRecipientRuleRepository.AddData(rARecipientRule);
                    var Rule = _RARecipientRuleRepository.GetSingle(Convert.ToInt32(recp));
                    switch (Rule.RecipientRuleName)
                    {
                        case "INFO 0 AND MASSN ":
                            Emp = _EmployeeInfoDataRepository.GetHiredEmployee();
                            Recipientcount += Emp.Count;
                            if (Emp.Count != 0)
                            {
                                foreach (var employee in Emp)
                                {
                                    RARecipient recipient = new RARecipient();
                                    recipient.EmployeeName = employee.FirstName + " " + employee.LastName;
                                    recipient.EmployeeEmail = employee.OIDEmailAddress;
                                    recipient.EmployeeNumber = employee.EmployeeNumberCode;
                                    recipient.Status = "Active";
                                    recipient.CreatedOn = DateTime.Now;
                                    var addrecipient = _RARecipientRepository.AddData(recipient);
                                    RABatchRecipient raBatchRecipientMap = new RABatchRecipient();
                                    raBatchRecipientMap.BatchId = oBatch.Id;
                                    raBatchRecipientMap.RecipientId = recipient.Id;
                                    var AddraBatchRecipientMap = _RABatchRecipientRepository.AddData(raBatchRecipientMap);
                                    //Template
                                    Template temp = _TemplateRepository.GetSingle(Batch.TemplateID);
                                    Notification notify = new Notification();
                                    notify.CreatedOn = DateTime.Now;
                                    notify.EmployeeNumber = employee.EmployeeNumberCode;
                                    notify.NotifyTo = employee.OIDEmailAddress;
                                    notify.NotifySubject = Batch.BatchName;
                                    notify.NotifyFrom = _FromMail;
                                    notify.NotifyStatus = "To Email";
                                    notify.NotifyBody = temp.TemplateBodyContent;
                                    notify.RequestType = "Email";
                                    notify.NotifyAttachment = temp.TemplateAttachmentContent;

                                    var AddNotifation = _NotificationRepository.AddData(notify);
                                }
                            }
                            break;

                        case "INFO 0 AND BEGDA":
                            Emp = _EmployeeInfoDataRepository.GetReHiredEmployee();
                            Recipientcount += Emp.Count;
                            if (Emp.Count != 0)
                            {
                                foreach (var employee in Emp)
                                {
                                    RARecipient recipient = new RARecipient();
                                    recipient.EmployeeName = employee.FirstName + " " + employee.LastName;
                                    recipient.EmployeeEmail = employee.OIDEmailAddress;
                                    recipient.EmployeeNumber = employee.EmployeeNumberCode;
                                    recipient.Status = "Active";
                                    recipient.CreatedOn = DateTime.Now;
                                    var addrecipient = _RARecipientRepository.AddData(recipient);
                                    RABatchRecipient raBatchRecipientMap = new RABatchRecipient();
                                    raBatchRecipientMap.BatchId = oBatch.Id;
                                    raBatchRecipientMap.RecipientId = recipient.Id;
                                    var AddraBatchRecipientMap = _RABatchRecipientRepository.AddData(raBatchRecipientMap);

                                    Template temp = _TemplateRepository.GetSingle(Batch.TemplateID);
                                    Notification notify = new Notification();
                                    notify.CreatedOn = DateTime.Now;
                                    notify.EmployeeNumber = employee.EmployeeNumberCode;
                                    notify.NotifyTo = employee.OIDEmailAddress;
                                    notify.NotifySubject = Batch.BatchName;
                                    notify.NotifyFrom = _FromMail;
                                    notify.NotifyStatus = "To Email";
                                    notify.NotifyBody = temp.TemplateBodyContent;
                                    notify.RequestType = "Email";
                                    var AddNotifation = _NotificationRepository.AddData(notify);
                                }
                            }
                            break;
                        case "INFO 1 AND STELL":
                            Emp = _EmployeeInfoDataRepository.GetChangesJobEmployee();
                            Recipientcount += Emp.Count;
                            if (Emp.Count != 0)
                            {
                                foreach (var employee in Emp)
                                {
                                    RARecipient recipient = new RARecipient();
                                    recipient.EmployeeName = employee.FirstName + " " + employee.LastName;
                                    recipient.EmployeeEmail = employee.OIDEmailAddress;
                                    recipient.EmployeeNumber = employee.EmployeeNumberCode;
                                    recipient.Status = "Active";
                                    recipient.CreatedOn = DateTime.Now;
                                    var addrecipient = _RARecipientRepository.AddData(recipient);
                                    RABatchRecipient raBatchRecipientMap = new RABatchRecipient();
                                    raBatchRecipientMap.BatchId = oBatch.Id;
                                    raBatchRecipientMap.RecipientId = recipient.Id;
                                    var AddraBatchRecipientMap = _RABatchRecipientRepository.AddData(raBatchRecipientMap);

                                    Template temp = _TemplateRepository.GetSingle(Batch.TemplateID);
                                    Notification notify = new Notification();
                                    notify.CreatedOn = DateTime.Now;
                                    notify.EmployeeNumber = employee.EmployeeNumberCode;
                                    notify.NotifyTo = employee.OIDEmailAddress;
                                    notify.NotifySubject = Batch.BatchName;
                                    notify.NotifyFrom = _FromMail;
                                    notify.NotifyStatus = "To Email";
                                    notify.NotifyBody = temp.TemplateBodyContent;
                                    notify.RequestType = "Email";
                                    var AddNotifation = _NotificationRepository.AddData(notify);
                                }
                            }
                            break;                                              
                    }

                }
                rASchedule.TotalRecipient = Recipientcount;
                rASchedule = _RAScheduleRepository.UpdateData(rASchedule);
            }           
            return Batch;

        }


        //Get AllRABatch 
        public IEnumerable<RABatchView> GetAllRABatch()
        {
            return _RABatchRepository.GetAllRABatch();
        }
        
        public RABatchView GetRABatchbyID(int Id)
        {
            return _RABatchRepository.GetSingle(Id);
        }

        //Get RABatchby By RABatchby_Id

        public RABatchViewModel GetBatchViewbyID(int Batchid)
        {
            return _RABatchRepository.GetBatchViewbyID(Batchid);
        }

        //Get Notfication list by BatchID

        public List<RANotificationViewModel> GetRANotificationList(int Batchid)
        {
            return _RABatchRepository.GetRANotificationList(Batchid);
        }
        public IEnumerable<RABatchView> GetAllRABiWeeklyBatch()
        {
            return _RABatchRepository.GetAllRABiWeeklyBatch();
        }

    }
}
