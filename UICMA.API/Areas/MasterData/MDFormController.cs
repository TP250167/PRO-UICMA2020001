using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.MD_Form;
using UICMA.Service;
using UICMA.Service.MasterData;

namespace UICMA.API.Areas.MasterData
{
    [Route("api/[controller]")]
    [ApiController]
    public class MDFormController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IMDFormService _MDFormService;

        public MDFormController(ILoggerManager logger, IMapper mapper, IMDFormService _MDFormService)
        {
            _logger = logger;
            _mapper = mapper;
            this._MDFormService = _MDFormService;
        }

        [HttpPost("AddandUpdateMDForm")]
        public MDForm AddandUpdateMDForm(MDForm mdForm)
        {
            return _MDFormService.AddandUpdateMDForm(mdForm);
        }

        [HttpGet("GetMDFormAll")]
        public ActionResult<IEnumerable<MDForm>> GetMDFormAll()
        {
            var result = _MDFormService.GetMDFormAll().ToList();
            return result;
        }

        [HttpGet("GetMDFormbyID/{id}")]
        public ActionResult<MDForm> GetMDFormbyID(int id)
        {
            var results = _MDFormService.GetMDFormbyID(id);
            return results;
        }


    }







}