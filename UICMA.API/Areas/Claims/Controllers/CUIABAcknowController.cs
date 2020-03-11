using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.CUIAB_Acknowledgement;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CUIABAcknowController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private ICUIABAcknowService _CUIABAcknowService;

        public CUIABAcknowController(ILoggerManager logger, IMapper mapper, ICUIABAcknowService _CUIABAcknowService)
        {
            _logger = logger;
            _mapper = mapper;
            this._CUIABAcknowService = _CUIABAcknowService;
        }

        [HttpPost("AddandUpdateCUIABAcknow")]
        public CUIABAcknowledgement AddandUpdateCUIABAcknow(CUIABAcknowledgement cuiaAck)
        {
            return _CUIABAcknowService.AddandUpdateCUIABAcknow(cuiaAck);
        }

        [HttpGet("GetCUIABAcknowAll")]
        public ActionResult<IEnumerable<CUIABAcknowledgement>> GetCUIABAcknowAll()
        {
            
            var result = _CUIABAcknowService.GetCUIABAcknowAll().ToList();
            return result;
        }

        [HttpGet("GetCUIABAcknowbyID/{id}")]
        public ActionResult<CUIABAcknowledgement> GetCUIABAcknowbyID(int id)
        {
            var results = _CUIABAcknowService.GetCUIABAcknowbyID(id);
            return results;
        }

    }
}