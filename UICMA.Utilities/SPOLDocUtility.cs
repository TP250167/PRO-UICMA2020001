﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.SharePoint.Client;



namespace UICMA.Utilities
{

    public class SPOLDocUtility
    {
        private string _errMsg;
        private SPAuthBO objAuth;
       

        public SPOLDocUtility(IConfiguration configuration)
        {
            this.objAuth = new SPAuthBO();           
            this.objAuth.UserName = configuration["SPOLConfig:SPUserName"];
            this.objAuth.UserPassword = configuration["SPOLConfig:SPPassword"];
            this.objAuth.SiteURL = configuration["SPOLConfig:SiteURL"];
            this.objAuth.Domain = configuration["SPOLConfig:Domain"];
         
        }

    
        private SharePointOnlineCredentials GetO365Credentials(string userName, string passWord)
        {
            SecureString securePassWord = new SecureString();
            foreach (char c in passWord.ToCharArray()) securePassWord.AppendChar(c);
            SharePointOnlineCredentials credentials = new SharePointOnlineCredentials(userName, passWord);
            return credentials;
        }

        #region Document Upload, Reterive and Update

        //Upload Document 
        public string AddDocument(DocRepositoryBO objDocRepo)
        {
            int DocItemID = 0;
            try
            {
                #region Document/file upload

                if (objDocRepo != null)
                {
                    ClientContext ctx = new ClientContext(this.objAuth.SiteURL);
                    ctx.RequestTimeout = 50000;  //1000000;
                    ctx.Credentials = GetO365Credentials(this.objAuth.UserName, this.objAuth.UserPassword);
                    Web web = ctx.Web;


                    using (FileStream fs = new FileStream(objDocRepo.FilePath, FileMode.Open))
                    {
                        FileCreationInformation fileInfo = new FileCreationInformation();
                        fileInfo.ContentStream = fs;
                        fileInfo.Url = Path.GetFileName(objDocRepo.FilePath);
                        fileInfo.Overwrite = true;
                        Microsoft.SharePoint.Client.List docs = web.Lists.GetByTitle(objDocRepo.DocumentLibraryName);
                        Microsoft.SharePoint.Client.File uploadFile = docs.RootFolder.Files.Add(fileInfo);
                        ctx.Load(uploadFile, f => f.ListItemAllFields);

                        ListItem item = uploadFile.ListItemAllFields;
                        if (objDocRepo.Title != null)
                            item["Title"] = objDocRepo.DocName.Trim();
                        if (objDocRepo.DocType != null)
                            item["DocumentType"] = objDocRepo.DocType.Trim();
                        item["DocumentName"] = objDocRepo.DocName;
                        item["DocumentNumber"] = objDocRepo.DocNumber;
                        item["Stage"] = objDocRepo.Stage;
                        item["Category"] = objDocRepo.Category;
                        item["ReqId"] = objDocRepo.ReqID;
                        item.Update();
                        if (ctx.HasPendingRequest)
                        {
                            ctx.ExecuteQueryAsync()
                            .Wait();
                        }
                        //ctx.ExecuteQueryAsync();
                        DocItemID = item.Id;
                    }



                }
                #endregion
            }
            catch (Exception ex)
            {

                return "Error:"+ex.Message;
            }

            return DocItemID.ToString();
        }

        //Get Documents
        public List<DocRepositoryBO> GetDocuments(string docLibName, int reqId)
        {


            string ContextSiteURL = this.objAuth.SiteURL;
            List<DocRepositoryBO> objDoc = new List<DocRepositoryBO>();
            try
            {


                using (ClientContext ctx = new ClientContext(this.objAuth.SiteURL))
                {
                    ctx.RequestTimeout = 50000;  //1000000;
                    ctx.Credentials = GetO365Credentials(this.objAuth.UserName, this.objAuth.UserPassword);
                    //List oList = ctx.Web.Lists.GetByTitle(DocRepName);
                    Microsoft.SharePoint.Client.List oList = ctx.Web.Lists.GetByTitle(docLibName);
                    CamlQuery camlQuery = new CamlQuery();
                    string sql1 =
                        @"<View>
                                <Query>
                                   <Where>
                                      <Eq>
                                         <FieldRef Name='ReqId' />
                                         <Value Type='Number'>@ReqId</Value>
                                      </Eq>
                                   </Where>
                                </Query>
                                <ViewFields>
                                   <FieldRef Name='ID' />
                                   <FieldRef Name='DocumentNumber' />
                                   <FieldRef Name='Title' />
                                   <FieldRef Name='DocumentType' />
                                   <FieldRef Name='FileRef' />         
                                   <FieldRef Name='FileLeafRef' /> 
                                   <FieldRef Name='DocumentName' />
                                   <FieldRef Name='ReqId' />
                                   <FieldRef Name='Category' />
                                   <FieldRef Name='Stage' />
                                   
                                </ViewFields>
                               </View>";
                    camlQuery.ViewXml = sql1.Replace("@ReqId", reqId.ToString());

                    ListItemCollection listItems = oList.GetItems(camlQuery);
                    ctx.Load(listItems);
                    if (ctx.HasPendingRequest)
                    {
                        ctx.ExecuteQueryAsync()
                        .Wait();
                    }
                    // ctx.ExecuteQueryAsync();

                    for (int idx = 0; idx < listItems.Count; idx++)
                    {


                        objDoc.Add(new DocRepositoryBO
                        {
                            DocID = listItems[idx].FieldValues["ID"] == DBNull.Value ? 0 : Convert.ToInt32(listItems[idx].FieldValues["ID"]),
                            DocNumber = listItems[idx].FieldValues["DocumentNumber"] == DBNull.Value ? string.Empty : Convert.ToString(listItems[idx].FieldValues["DocumentNumber"]),
                            DocName = listItems[idx].FieldValues["DocumentName"] == DBNull.Value ? string.Empty : Convert.ToString(listItems[idx].FieldValues["DocumentName"]),
                            Category = listItems[idx].FieldValues["Category"] == DBNull.Value ? string.Empty : Convert.ToString(listItems[idx].FieldValues["Category"]),
                            Stage = listItems[idx].FieldValues["Stage"] == DBNull.Value ? 0 : Convert.ToInt32(listItems[idx].FieldValues["Stage"]),

                            DocType = listItems[idx].FieldValues["DocumentType"] == null ? string.Empty : Convert.ToString(listItems[idx].FieldValues["DocumentType"]),
                            Title = listItems[idx].FieldValues["Title"] == null ? string.Empty : Convert.ToString(listItems[idx].FieldValues["Title"]),
                            FilePath = listItems[idx].FieldValues["FileRef"] == DBNull.Value ? string.Empty : Convert.ToString(listItems[idx].FieldValues["FileRef"]),
                            //DocVersion = listItems[idx].FieldValues["VersionNo"] == DBNull.Value ? string.Empty : Convert.ToString(listItems[idx].FieldValues["VersionNo"]),
                            ReqID = listItems[idx].FieldValues["ReqId"] == DBNull.Value ? 0 : Convert.ToInt32(listItems[idx].FieldValues["ReqId"]),
                            //SPFilePath = this.objAuth.Domain + (listItems[idx].FieldValues["FileRef"] == DBNull.Value ? string.Empty : Convert.ToString(listItems[idx].FieldValues["FileRef"]))
                            SPFilePathUri = getSPFilePathUri(this.objAuth.SiteURL, (listItems[idx].FieldValues["FileRef"] == DBNull.Value ? string.Empty : Convert.ToString(listItems[idx].FieldValues["FileRef"])))

                        });
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }
            return objDoc;
        }
        public List<DocRepositoryBO> GetDocuments(string docLibName, int reqId, string documentType)
        {


            string ContextSiteURL = this.objAuth.SiteURL;
            List<DocRepositoryBO> objDoc = new List<DocRepositoryBO>();
            try
            {


                using (ClientContext ctx = new ClientContext(this.objAuth.SiteURL))
                {
                    ctx.RequestTimeout = 50000;  //1000000;

                    //SecureString secureString = new SecureString();
                    //foreach (char c in "Password".ToCharArray())
                    //{
                    //    secureString.AppendChar(c);
                    //}
                    //ICredentials credentials = new SharePointOnlineCredentials("xxxxxx.onmicrosoft.com", secureString);
                   
                    ctx.Credentials = GetO365Credentials(this.objAuth.UserName, this.objAuth.UserPassword);
                    //List oList = ctx.Web.Lists.GetByTitle(DocRepName);
                    Microsoft.SharePoint.Client.List oList = ctx.Web.Lists.GetByTitle(docLibName);
                    CamlQuery camlQuery = new CamlQuery();
                    string sql1 =
                        @"<View>
                                <Query>
                                   <Where>
                                    <And>
                                      <Eq>
                                         <FieldRef Name='ReqId' />
                                         <Value Type='Number'>@ReqId</Value>
                                      </Eq>
                                      <Eq>
                                       <FieldRef Name='DocumentType' />
                                       <Value Type='Text'>@DocType</Value>
                                      </Eq>
                                      </And>
                                   </Where>
                                </Query>
                                <ViewFields>
                                   <FieldRef Name='ID' />
                                   <FieldRef Name='DocumentNumber' />
                                   <FieldRef Name='Title' />
                                   <FieldRef Name='DocumentType' />
                                   <FieldRef Name='FileRef' />   
                                   <FieldRef Name='FileLeafRef' /> 
                                   <FieldRef Name='DocumentName' />
                                   <FieldRef Name='ReqId' />
                                   <FieldRef Name='Category' />
                                   <FieldRef Name='Stage' />
                                   
                                </ViewFields>
                               </View>";
                    camlQuery.ViewXml = sql1.Replace("@ReqId", reqId.ToString()).Replace("@DocType", documentType);

                    ListItemCollection listItems = oList.GetItems(camlQuery);
                    ctx.Load(listItems);
                    if (ctx.HasPendingRequest)
                    {
                        ctx.ExecuteQueryAsync()
                        .Wait();
                    }
                    // ctx.ExecuteQueryAsync();

                    for (int idx = 0; idx < listItems.Count; idx++)
                    {

                      
                        objDoc.Add(new DocRepositoryBO
                        {
                            DocID = listItems[idx].FieldValues["ID"] == DBNull.Value ? 0 : Convert.ToInt32(listItems[idx].FieldValues["ID"]),
                            DocNumber = listItems[idx].FieldValues["DocumentNumber"] == DBNull.Value ? string.Empty : Convert.ToString(listItems[idx].FieldValues["DocumentNumber"]),
                            DocName = listItems[idx].FieldValues["DocumentName"] == DBNull.Value ? string.Empty : Convert.ToString(listItems[idx].FieldValues["DocumentName"]),
                            DocType = listItems[idx].FieldValues["DocumentType"] == null ? string.Empty : Convert.ToString(listItems[idx].FieldValues["DocumentType"]),
                            Category = listItems[idx].FieldValues["Category"] == DBNull.Value ? string.Empty : Convert.ToString(listItems[idx].FieldValues["Category"]),
                            Stage = listItems[idx].FieldValues["Stage"] == DBNull.Value ? 0 : Convert.ToInt32(listItems[idx].FieldValues["Stage"]),

                            Title = listItems[idx].FieldValues["Title"] == null ? string.Empty : Convert.ToString(listItems[idx].FieldValues["Title"]),
                            FilePath = listItems[idx].FieldValues["FileRef"] == DBNull.Value ? string.Empty : Convert.ToString(listItems[idx].FieldValues["FileRef"]),
                            //DocVersion = listItems[idx].FieldValues["VersionNo"] == DBNull.Value ? string.Empty : Convert.ToString(listItems[idx].FieldValues["VersionNo"]),
                            ReqID = listItems[idx].FieldValues["ReqId"] == DBNull.Value ? 0 : Convert.ToInt32(listItems[idx].FieldValues["ReqId"]),
                            //SPFilePath = this.objAuth.Domain + (listItems[idx].FieldValues["FileRef"] == DBNull.Value ? string.Empty : Convert.ToString(listItems[idx].FieldValues["FileRef"])),
                           SPFilePathUri = getSPFilePathUri(this.objAuth.SiteURL, (listItems[idx].FieldValues["FileRef"] == DBNull.Value ? string.Empty : Convert.ToString(listItems[idx].FieldValues["FileRef"])))
                           
                        }) ;
                       // string fileName = listItems[idx].FieldValues["FileLeafRef"] == DBNull.Value ? string.Empty : Convert.ToString(listItems[idx].FieldValues["FileLeafRef"]);
                        //DownloadFileViaRestAPI(this.objAuth.SiteURL, docLibName, fileName,"c:\\");
                    }
                }
            }
            catch (Exception ex)
            {
                _errMsg = ex.Message;
            }
            return objDoc;
        }
       
        //Update Documents
        public string UpdateDocument(DocRepositoryBO objDocRepo)
        {
            int DocItemID = 0;
            try
            {
                #region Document/file upload

                ClientContext ctx = new ClientContext(this.objAuth.SiteURL);
                ctx.RequestTimeout = 50000;  //1000000;
                ctx.Credentials = GetO365Credentials(this.objAuth.UserName, this.objAuth.UserPassword);
                Web web = ctx.Web;

                Microsoft.SharePoint.Client.File uploadFile = web.GetFileByServerRelativeUrl(objDocRepo.FilePath);
                if (uploadFile.CheckOutType != CheckOutType.Online)
                    uploadFile.CheckOut();
                if (objDocRepo != null)
                {


                    using (FileStream fs = new FileStream(objDocRepo.FilePath, FileMode.Open))
                    {
                        FileCreationInformation fileInfo = new FileCreationInformation();
                        fileInfo.ContentStream = fs;
                        fileInfo.Url = Path.GetFileName(objDocRepo.FilePath);
                        fileInfo.Overwrite = true;
                        Microsoft.SharePoint.Client.List docs = web.Lists.GetByTitle(objDocRepo.DocumentLibraryName);
                        uploadFile = docs.RootFolder.Files.Add(fileInfo);
                        ctx.Load(uploadFile, f => f.ListItemAllFields);

                        ListItem item = uploadFile.ListItemAllFields;
                        if (objDocRepo.Title != null)
                            item["Title"] = objDocRepo.DocName.Trim();
                        if (objDocRepo.DocType != null)
                            item["DocumentType"] = objDocRepo.DocType.Trim();
                        item["DocumentName"] = objDocRepo.DocName;
                        item["DocumentNumber"] = objDocRepo.DocNumber;
                        item["Stage"] = objDocRepo.Stage;
                        item["Category"] = objDocRepo.Category;
                        item["ReqId"] = objDocRepo.ReqID;
                        item.Update();
                        if (ctx.HasPendingRequest)
                        {
                            ctx.ExecuteQueryAsync()
                            .Wait();
                        }
                        DocItemID = item.Id;
                    }



                }
                #endregion
            }
            catch (Exception ex)
            {

                return "Error:"+ex.Message;
            }

            return DocItemID.ToString();
        }

        //Delete Documents
        public string DeleteDocument(string RepoName, string DocId)
        {
            string msg;
            try
            {


                ClientContext ctx = new ClientContext(this.objAuth.SiteURL);
                ctx.RequestTimeout = 50000;
                ctx.Credentials = this.GetO365Credentials(this.objAuth.UserName, this.objAuth.UserPassword);
                Web web = ctx.Web;
                Microsoft.SharePoint.Client.List oList = web.Lists.GetByTitle(RepoName);

                ListItem DocToDelete = oList.GetItemById(DocId);
                DocToDelete.DeleteObject();
                oList.Update();
                if (ctx.HasPendingRequest)
                {
                    ctx.ExecuteQueryAsync()
                    .Wait();
                }

                msg = "Document Removed from Repository";

            }
            catch (Exception ex)
            {
                return "Error:"+ex.Message;
            }
            return msg;
        }

        private  string  DownloadFileViaRestAPI(string webUrl,  string docLib, string fileName, string path)
        {
            webUrl = webUrl.EndsWith("/") ? webUrl.Substring(0, webUrl.Length - 1) : webUrl;
            string webRelativeUrl = null;
            if (webUrl.Split('/').Length > 3)
            {
                webRelativeUrl = "/" + webUrl.Split(new char[] { '/' }, 4)[3];
            }
            else
            {
                webRelativeUrl = "";
            }

            using (WebClient client = new WebClient())
            {
                client.Headers.Add("X-FORMS_BASED_AUTH_ACCEPTED", "f");
                client.Credentials = GetO365Credentials(this.objAuth.UserName,this.objAuth.UserPassword);
                //Uri endpointUri = new Uri(webUrl + "/_api/web/GetFileByServerRelativeUrl('" + webRelativeUrl + "/" + documentLibName + "/" + fileName + "')/$value");
                Uri endpointUri= new Uri(this.objAuth.Domain+"/_api/web/GetFileByServerRelativeUrl('" + webRelativeUrl + "/" + docLib + "/" + fileName + "')/$value");                
                byte[] data = client.DownloadData(endpointUri);
                
                FileStream outputStream = new FileStream(path + fileName, FileMode.OpenOrCreate | FileMode.Append, FileAccess.Write, FileShare.None);
                outputStream.Write(data, 0, data.Length);
                outputStream.Flush(true);
                outputStream.Close();

            }


            return path + fileName;
        }

         
        private Uri getSPFilePathUri(string webUrl, string filePath)
        {
            webUrl = webUrl.EndsWith("/") ? webUrl.Substring(0, webUrl.Length - 1) : webUrl;
            string webRelativeUrl = null;
            if (webUrl.Split('/').Length > 3)
            {
                webRelativeUrl = "/" + webUrl.Split(new char[] { '/' }, 4)[3];
            }
            else
            {
                webRelativeUrl = "";
            }
            return new Uri(webUrl + "/_api/web/GetFileByServerRelativeUrl('" + webRelativeUrl +filePath+ "')/$value");
        }

        #endregion
    }
}
