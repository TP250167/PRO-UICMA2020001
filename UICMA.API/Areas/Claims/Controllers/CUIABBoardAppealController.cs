using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.CUIAB_Board_Appeal;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CUIABBoardAppealController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private ICUIABBoardAppealService _CUIABBoardAppeal;

        public CUIABBoardAppealController(ILoggerManager logger, IMapper mapper, ICUIABBoardAppealService _CUIABBoardAppeal)
        {
            _logger = logger;
            _mapper = mapper;
            this._CUIABBoardAppeal = _CUIABBoardAppeal;
        }

        [HttpPost("AddandUpdateCUIABBoardAppeal")]
        public CUIABBoardAppeal AddandUpdateCUIABBoardAppeal(CUIABBoardAppeal cuiaAck)
        {
            return _CUIABBoardAppeal.AddandUpdateCUIABBoardAppeal(cuiaAck);
        }

        [HttpGet("GetCUIABBoardAppealAll")]
        public ActionResult<IEnumerable<CUIABBoardAppeal>> GetCUIABBoardAppealAll()
        {

            var result = _CUIABBoardAppeal.GetCUIABBoardAppealAll().ToList();
            return result;
        }

        [HttpGet("GetCUIABBoardAppealbyID/{id}")]
        public ActionResult<CUIABBoardAppeal> GetCUIABBoardAppealbyID(int id)
        {
            var results = _CUIABBoardAppeal.GetCUIABBoardAppealbyID(id);
            return results;
        }

    }
}