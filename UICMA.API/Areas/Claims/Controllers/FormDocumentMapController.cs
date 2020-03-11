using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Form_Document;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormDocumentMapController : ControllerBase
    {

        private ILoggerManager _logger;
        private IMapper _mapper;
        private IFormDocumentMapService _FormDocumentMapService;

        public FormDocumentMapController(ILoggerManager logger, IMapper mapper, IFormDocumentMapService _FormDocumentMapService)
        {
            _logger = logger;
            _mapper = mapper;
            this._FormDocumentMapService = _FormDocumentMapService;
        }

        [HttpPost("AddandUpdateFormDocument")]
        public FormDocument AddandUpdateFormDocument(FormDocument formDocument)
        {
            return _FormDocumentMapService.AddandUpdateFormDocument(formDocument);
        }

        [HttpGet("GetFormDocumentAll")]
        public ActionResult<IEnumerable<FormDocument>> GetFormDocumentAll()

        {
            var result = _FormDocumentMapService.GetFormDocumentAll().ToList();
            return result;
        }

        [HttpGet("GetFormDocumentbyID/{id}")]
        public ActionResult<FormDocument> GetFormDocumentbyID(int id)
        {
            var results = _FormDocumentMapService.GetFormDocumentbyID(id);
            return results;
        }

    }
}