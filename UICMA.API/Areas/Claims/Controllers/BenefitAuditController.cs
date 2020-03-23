using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Benefit_Audit;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenefitAuditController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IBenefitAuditService _BenefitAuditService;

        public BenefitAuditController(ILoggerManager logger, IMapper mapper, IBenefitAuditService _BenefitAuditService)
        {
            _logger = logger;
            _mapper = mapper;
            this._BenefitAuditService = _BenefitAuditService;
        }

        [HttpPost("AddandUpdateBenefitAudit")]
        public BenefitAudit AddandUpdateBenefitAudit(BenefitAudit cuiaAck)
        {
            return _BenefitAuditService.AddandUpdateBenefitAudit(cuiaAck);
        }

        [HttpGet("GetBenefitAuditAll")]
        public ActionResult<IEnumerable<BenefitAudit>> GetBenefitAuditAll()
        {

            var result = _BenefitAuditService.GetBenefitAuditAll().ToList();
            return result;
        }

        [HttpGet("GetBenefitAuditbyID/{id}")]
        public ActionResult<BenefitAudit> GetBenefitAuditbyID(int id)
        {
            var results = _BenefitAuditService.GetBenefitAuditbyID(id);
            return results;
        }

    }
}