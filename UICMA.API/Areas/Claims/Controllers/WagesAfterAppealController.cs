using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Wages_After_Appeal;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WagesAfterAppealController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IWagesAfterAppealService _WagesAfterAppealService;

        public WagesAfterAppealController(ILoggerManager logger, IMapper mapper, IWagesAfterAppealService _WagesAfterAppealService)
        {
            _logger = logger;
            _mapper = mapper;
            this._WagesAfterAppealService = _WagesAfterAppealService;
        }

        [HttpPost("AddandUpdateWagesAfterAppeal")]
        public WagesAfterAppeal AddandUpdateWagesAfterAppeal(WagesAfterAppeal claimAppeal)
        {
            return _WagesAfterAppealService.AddandUpdateWagesAfterAppeal(claimAppeal);
        }

        [HttpGet("GetWagesAfterAppealAll")]
        public ActionResult<IEnumerable<WagesAfterAppeal>> GetWagesAfterAppealAll()

        {
            var result = _WagesAfterAppealService.GetWagesAfterAppealAll().ToList();
            return result;
        }

        [HttpGet("GetWagesAfterAppealbyID/{id}")]
        public ActionResult<WagesAfterAppeal> GetWagesAfterAppealbyID(int id)
        {
            var results = _WagesAfterAppealService.GetWagesAfterAppealbyID(id);
            return results;
        }

    }
}