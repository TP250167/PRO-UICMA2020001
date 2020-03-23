using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Wages_Appeal;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class WagesAppealController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IWagesAppealService _WagesAppealService;

        public WagesAppealController(ILoggerManager logger, IMapper mapper, IWagesAppealService _WagesAppealService)
        {
            _logger = logger;
            _mapper = mapper;
            this._WagesAppealService = _WagesAppealService;
        }

        [HttpPost("AddandUpdateWagesAppeal")]
        public WagesAppeal AddandUpdateWagesAppeal(WagesAppeal aljDecision)
        {
            return _WagesAppealService.AddandUpdateWagesAppeal(aljDecision);
        }

        [HttpGet("GetWagesAppealAll")]
        public ActionResult<IEnumerable<WagesAppeal>> GetWagesAppealAll()

        {
            var result = _WagesAppealService.GetWagesAppealAll().ToList();
            return result;
        }

        [HttpGet("GetWagesAppealbyID/{id}")]
        public ActionResult<WagesAppeal> GetWagesAppealbyID(int id)
        {
            var results = _WagesAppealService.GetWagesAppealbyID(id);
            return results;
        }

    }
}