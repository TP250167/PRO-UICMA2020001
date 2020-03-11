using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Claim_Determination;
using UICMA.Service;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimDeterminationController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IClaimDeterminationService _ClaimDetermination;

        public ClaimDeterminationController(ILoggerManager logger, IMapper mapper, IClaimDeterminationService _ClaimDetermination)
        {
            _logger = logger;
            _mapper = mapper;
            this._ClaimDetermination = _ClaimDetermination;
        }

        [HttpPost("AddandUpdateClaimDetermination")]
        public ClaimDetermination AddandUpdateClaimDetermination(ClaimDetermination claimDetermination)
        {
            return _ClaimDetermination.AddandUpdateClaimDetermination(claimDetermination);
        }

        [HttpGet("GetClaimDeterminationAll")]
        public ActionResult<IEnumerable<ClaimDetermination>> GetClaimDeterminationAll()

        {
            var result = _ClaimDetermination.GetClaimDeterminationAll().ToList();
            return result;
        }

        [HttpGet("GetClaimDeterminationbyID/{id}")]
        public ActionResult<ClaimDetermination> GetClaimDeterminationbyID(int id)
        {
            var results = _ClaimDetermination.GetClaimDeterminationbyID(id);
            return results;
        }

    }
}