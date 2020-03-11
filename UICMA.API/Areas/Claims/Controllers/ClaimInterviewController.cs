using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Claim_Interview;
using UICMA.Service;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimInterviewController : ControllerBase
    {

               private ILoggerManager _logger;
        private IMapper _mapper;
        private IClaimInterviewService _ClaimInterviewService;

        public ClaimInterviewController(ILoggerManager logger, IMapper mapper, IClaimInterviewService _ClaimInterviewService)
        {
            _logger = logger;
            _mapper = mapper;
            this._ClaimInterviewService = _ClaimInterviewService;
        }

        [HttpPost("AddandUpdateClaimInterview")]
        public ClaimInterview AddandUpdateClaimInterview(ClaimInterview claimInterview)
        {
            return _ClaimInterviewService.AddandUpdateClaimInterview(claimInterview);
        }

        [HttpGet("GetClaimInterviewAll")]
        public ActionResult<IEnumerable<ClaimInterview>> GetClaimInterviewAll()

        {
            var result = _ClaimInterviewService.GetClaimInterviewAll().ToList();
            return result;
        }

        [HttpGet("GetClaimInterviewbyID/{id}")]
        public ActionResult<ClaimInterview> GetClaimInterviewbyID(int id)
        {
            var results = _ClaimInterviewService.GetClaimInterviewbyID(id);
            return results;
        }

    }
}