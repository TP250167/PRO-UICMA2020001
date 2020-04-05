using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Utilities;
namespace UICMA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        DocumentController()
        {
           
        }
       
        // GET: api/Document
        [HttpGet("{ReqId}", Name = "Get")]
        public IEnumerable<DocRepositoryBO> Get(int ReqId)
        {
            SPOLDocUtility objUtil = new SPOLDocUtility();
            List<DocRepositoryBO> objDocs = new List<DocRepositoryBO>();
            SPAuthBO objAuth = new SPAuthBO();
            objAuth.UserName = "gb-itadmin@kosoft.co";
            objAuth.UserPassword = "";
            objAuth.Domain = "https://kosoftsolutions.sharepoint.com/";
            objAuth.SiteURL = "https://kosoftsolutions.sharepoint.com/";
            try
            {

                objDocs = objUtil.GetDocuments(objAuth,"TestLibrary",1);
            }
            catch (Exception)
            {

                throw;
            }
            return objDocs;
        }
        public IEnumerable<DocRepositoryBO> Get(int ReqId,string docType)
        {
            SPOLDocUtility objUtil = new SPOLDocUtility();
            List<DocRepositoryBO> objDocs = new List<DocRepositoryBO>();
            SPAuthBO objAuth = new SPAuthBO();
            objAuth.UserName = "gb-itadmin@kosoft.co";
            objAuth.UserPassword = "";
            objAuth.Domain = "https://kosoftsolutions.sharepoint.com/";
            objAuth.SiteURL = "https://kosoftsolutions.sharepoint.com/";
            try
            {

                objDocs = objUtil.GetDocuments(objAuth, "TestLibrary", 1, docType);
            }
            catch (Exception)
            {

                throw;
            }
            return objDocs;
        }

        //// GET: api/Document/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Document
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Document/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
