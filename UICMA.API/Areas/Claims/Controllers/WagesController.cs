using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.NoticeOfWages;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class WagesController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IWagesService _WagesService;

        public WagesController(ILoggerManager logger, IMapper mapper, IWagesService _WagesService)
        {
            _logger = logger;
            _mapper = mapper;
            this._WagesService = _WagesService;
        }

        [HttpPost("AddandUpdateWages")]
        public Wages AddandUpdateWages(Wages Wages)
        {
            return _WagesService.AddandUpdateWages(Wages);
        }

        [HttpGet("GetWagesAll")]
        public ActionResult<IEnumerable<Wages>> GetWagesAll()

        {
            var result = _WagesService.GetWagesAll().ToList();
            return result;
        }

        [HttpGet("GetWagesbyID/{id}")]
        public ActionResult<Wages> GetWagesbyID(int id)
        {
            var results = _WagesService.GetWagesbyID(id);
            return results;
        }

    }
}