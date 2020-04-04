using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.MD_Document;
using UICMA.Service;
using UICMA.Service.MasterData;

namespace UICMA.API.Areas.MasterData
{
    [Route("api/[controller]")]
    [ApiController]
    public class MDDocumentController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IMDDocumentService _MDDocumentService;

        public MDDocumentController(ILoggerManager logger, IMapper mapper, IMDDocumentService _MDDocumentService)
        {
            _logger = logger;
            _mapper = mapper;
            this._MDDocumentService = _MDDocumentService;
        }

        [HttpPost("AddandUpdateMDDocument")]
        public MDDocument AddandUpdateMDDocument(MDDocument documentr)
        {
            return _MDDocumentService.AddandUpdateMDDocument(documentr);
        }

        [HttpGet("GetMDDocumentAll")]
        public ActionResult<IEnumerable<MDDocument>> GetMDDocumentAll()

        {
            var result = _MDDocumentService.GetMDDocumentAll().ToList();
            return result;
        }

        [HttpGet("GetMDDocumentbyID/{id}")]
        public ActionResult<MDDocument> GetMDDocumentbyID(int id)
        {
            var results = _MDDocumentService.GetMDDocumentbyID(id);
            return results;
        }


    }







}