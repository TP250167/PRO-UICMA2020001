using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Claim_Response;
using UICMA.Service;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimResponseController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IClaimResponseService _ClaimResponseService;

        public ClaimResponseController(ILoggerManager logger, IMapper mapper, IClaimResponseService _ClaimResponseService)
        {
            _logger = logger;
            _mapper = mapper;
            this._ClaimResponseService = _ClaimResponseService;
        }

        [HttpPost("AddandUpdateClaimResponse")]
        public ClaimResponse AddandUpdateClaimResponse(ClaimResponse claimResponse)
        {
            return _ClaimResponseService.AddandUpdateClaimResponse(claimResponse);
        }

        [HttpGet("GetClaimResponseAll")]
        public ActionResult<IEnumerable<ClaimResponse>> GetClaimResponseAll()

        {
            var result = _ClaimResponseService.GetClaimResponseAll().ToList();
            return result;
        }

        [HttpGet("GetClaimResponsebyID/{id}")]
        public ActionResult<ClaimResponse> GetClaimResponsebyID(int id)
        {
            var results = _ClaimResponseService.GetClaimResponsebyID(id);
            return results;
        }

    }
}