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
        public IActionResult GetDocuments(int reqId)
        {
            SPOLDocUtility objUtil = new SPOLDocUtility(this.configuration);
            List<DocRepositoryBO> objDocs = new List<DocRepositoryBO>();

            try
            {

                objDocs = objUtil.GetDocuments("TestLibrary", reqId);
                if (objDocs == null)
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            return Ok(objDocs);
        }

        // GET: api/Document

        [HttpGet("GetDocumentByType/{reqId:int}/{docType}/")]
        public  IActionResult GetDocuments(int reqId, string docType)
        {
            SPOLDocUtility objUtil = new SPOLDocUtility(this.configuration);
            List<DocRepositoryBO> objDocs = new List<DocRepositoryBO>();
            
            try
            {

                objDocs = objUtil.GetDocuments( "TestLibrary", reqId, docType);
                if (objDocs==null)
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            return Ok(objDocs);
        }

    

        // POST: api/Document
        [HttpPost]
        public IActionResult Post([FromBody] DocRepositoryBO document)
        {
            SPOLDocUtility objUtil = new SPOLDocUtility(this.configuration);

            string result;
            try
            {

                result= objUtil.AddDocument(document);
                if (result.Contains("Error:"))
                {
                    return BadRequest(result);
                }


               
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message) ;
            }
            return Ok(result);
        }

        // PUT: api/Document
        [HttpPut]
        public IActionResult Put([FromBody] DocRepositoryBO document)
        {
            SPOLDocUtility objUtil = new SPOLDocUtility(this.configuration);

            string result;
            try
            {

               result= objUtil.UpdateDocument(document);
                if (result.Contains("Error:"))
                {
                    return BadRequest(result);
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            return Ok(result);
        
    }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{docId:int}")]
        public IActionResult Delete(int docId)
        {

            SPOLDocUtility objUtil = new SPOLDocUtility(this.configuration);

            string result;
            try
            {

              result = objUtil.DeleteDocument("TestLibrary",docId.ToString());
                if (result.Contains("Error:"))
                {
                    return BadRequest(result);
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            return Ok(result);
        }
    }
}
