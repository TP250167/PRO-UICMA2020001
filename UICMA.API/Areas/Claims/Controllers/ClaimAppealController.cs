using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Claim_Appeal;
using UICMA.Service;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimAppealController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IClaimAppealService _ClaimAppealService;

        public ClaimAppealController(ILoggerManager logger, IMapper mapper, IClaimAppealService _ClaimAppealService)
        {
            _logger = logger;
            _mapper = mapper;
            this._ClaimAppealService = _ClaimAppealService;
        }

        [HttpPost("AddandUpdateclaimAppeal")]
        public ClaimAppeal AddandUpdateclaimAppeal (ClaimAppeal claimAppeal)
        {
            return _ClaimAppealService.AddandUpdateclaimAppeal(claimAppeal);
        }
        
        [HttpGet("GetclaimAppealAll")]
        public ActionResult<IEnumerable<ClaimAppeal>> GetclaimAppealAll()
        {                      
            var result = _ClaimAppealService.GetclaimAppealAll().ToList();
            return result;
        }

        [HttpGet("GetMasterApplicationbyId/{id}")]
        public ActionResult<ClaimAppeal> GetMasterApplicationbyId(int id)
        {
            var results = _ClaimAppealService.GetclaimAppealbyID(id);
            return results;
        }


    }
}