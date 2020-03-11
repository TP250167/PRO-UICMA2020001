using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.New_Claim;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewClaimController : ControllerBase
    {

        private ILoggerManager _logger;
        private IMapper _mapper;
        private INewClaimService _NewClaimService;

        public NewClaimController(ILoggerManager logger, IMapper mapper, INewClaimService _NewClaimService)
        {
            _logger = logger;
            _mapper = mapper;
            this._NewClaimService = _NewClaimService;
        }

        [HttpPost("AddandUpdateNewClaim")]
        public Claim AddandUpdateNewClaim(Claim newClaim)
        {
            return _NewClaimService.AddandUpdateNewClaim(newClaim);
        }

        [HttpGet("GetNewClaimAll")]
        public ActionResult<IEnumerable<Claim>> GetNewClaimAll()

        {
            var result = _NewClaimService.GetNewClaimAll().ToList();
            return result;
        }

        [HttpGet("GetNewclaimbyID/{id}")]
        public ActionResult<Claim> GetNewclaimbyID(int id)
        {
            var results = _NewClaimService.GetNewclaimbyID(id);
            return results;
        }

    }
}