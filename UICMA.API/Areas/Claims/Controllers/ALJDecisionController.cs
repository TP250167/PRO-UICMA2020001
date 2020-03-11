using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.ALJ_Decision;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ALJDecisionController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IALJDecisionService _ALJDecisionService;

        public ALJDecisionController(ILoggerManager logger, IMapper mapper, IALJDecisionService _ALJDecisionService)
        {
            _logger = logger;
            _mapper = mapper;
            this._ALJDecisionService = _ALJDecisionService;
        }

        [HttpPost("AddandUpdateALJDecision")]
        public ALJDecision AddandUpdateALJDecision(ALJDecision aljDecision)
        {
            return _ALJDecisionService.AddandUpdateALJDecision(aljDecision);
        }

        [HttpGet("GetALJDecisionAll")]
        public ActionResult<IEnumerable<ALJDecision>> GetALJDecisionAll()

        {
            var result = _ALJDecisionService.GetALJDecisionAll().ToList();
            return result;
        }

        [HttpGet("GetALJDecisionbyID/{id}")]
        public ActionResult<ALJDecision>GetALJDecisionbyID(int id)
        {
            var results = _ALJDecisionService.GetALJDecisionbyID(id);
            return results;
        }

    }
}