using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.RARecipientRules;
using UICMA.Service;
using UICMA.Service.RAService;

namespace UICMA.API.Areas.RA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RARecipientRuleController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IRARecipientRuleService _RARecipientRuleService;
        public RARecipientRuleController(ILoggerManager logger, IMapper mapper, IRARecipientRuleService _RARecipientRuleService)
        {
            _logger = logger;
            _mapper = mapper;
            this._RARecipientRuleService = _RARecipientRuleService;
        }
        [HttpGet("GetAllRARecipientRule")]
        public IEnumerable<RARecipientRule> GetAllRARecipientRule()
        {
            var result = _RARecipientRuleService.GetAllRARecipientRule().ToList();
            return result;
        }
    }
}


