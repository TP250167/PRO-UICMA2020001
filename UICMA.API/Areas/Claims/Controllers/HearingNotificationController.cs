using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Hearings;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HearingNotificationController : ControllerBase
    {

        private ILoggerManager _logger;
        private IMapper _mapper;
        private IHearingService _HearingService;

        public HearingNotificationController(ILoggerManager logger, IMapper mapper, IHearingService _HearingService)
        {
            _logger = logger;
            _mapper = mapper;
            this._HearingService = _HearingService;
        }

        [HttpPost("AddandUpdateHearing")]
        public Hearing AddandUpdateHearing(Hearing hearingNot)
        {
            return _HearingService.AddandUpdateHearing(hearingNot);
        }

        [HttpGet("GetHearingAll")]
        public ActionResult<IEnumerable<Hearing>>GetHearingAll()

        {
            var result = _HearingService.GetHearingAll().ToList();
            return result;
        }

        [HttpGet("GetHearingbyID/{id}")]
        public ActionResult<Hearing>GetHearingbyID(int id)
        {
            var results = _HearingService.GetHearingbyID(id);
            return results;
        }









    }
}