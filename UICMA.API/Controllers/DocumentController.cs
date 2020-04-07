using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using UICMA.Utilities;
namespace UICMA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IConfiguration configuration;       
        public DocumentController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // GET: api/Document
        [HttpGet("GetDocument/{reqId:int}")]
        public IEnumerable<DocRepositoryBO> GetDocuments(int reqId)
        {
            SPOLDocUtility objUtil = new SPOLDocUtility(this.configuration);
            List<DocRepositoryBO> objDocs = new List<DocRepositoryBO>();
           
            try
            {

                objDocs = objUtil.GetDocuments("TestLibrary",reqId);
            }
            catch (Exception)
            {

                throw;
            }
            return objDocs;
        }

        // GET: api/Document

        [HttpGet("GetDocumentByType/{reqId:int}/{docType}/")]
        public IEnumerable<DocRepositoryBO> GetDocuments(int reqId, string docType)
        {
            SPOLDocUtility objUtil = new SPOLDocUtility(this.configuration);
            List<DocRepositoryBO> objDocs = new List<DocRepositoryBO>();
            
            try
            {

                objDocs = objUtil.GetDocuments( "TestLibrary", reqId, docType);
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
