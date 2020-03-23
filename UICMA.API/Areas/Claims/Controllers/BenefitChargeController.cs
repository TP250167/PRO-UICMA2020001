using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Benefit_Charge;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenefitChargeController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IBenefitChargeService _BenefitCharge;

        public BenefitChargeController(ILoggerManager logger, IMapper mapper, IBenefitChargeService _BenefitCharge)
        {
            _logger = logger;
            _mapper = mapper;
            this._BenefitCharge = _BenefitCharge;
        }

        [HttpPost("AddandUpdateBenefitCharge")]
        public BenefitCharge AddandUpdateBenefitCharge(BenefitCharge cuiaAck)
        {
            return _BenefitCharge.AddandUpdateBenefitCharge(cuiaAck);
        }

        [HttpGet("GetBenefitChargeAll")]
        public ActionResult<IEnumerable<BenefitCharge>> GetBenefitChargeAll()
        {

            var result = _BenefitCharge.GetBenefitChargeAll().ToList();
            return result;
        }

        [HttpGet("GetBenefitChargebyID/{id}")]
        public ActionResult<BenefitCharge> GetBenefitChargebyID(int id)
        {
            var results = _BenefitCharge.GetBenefitChargebyID(id);
            return results;
        }

    }
}