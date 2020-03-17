using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Templates;
using UICMA.Service;
using UICMA.Service.RAService;

namespace UICMA.API.Areas.RA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RATemplateController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IRATemplateService _RATemplateService;
        public RATemplateController(ILoggerManager logger, IMapper mapper, IRATemplateService _RATemplateService)
        {
            _logger = logger;
            _mapper = mapper;
            this._RATemplateService = _RATemplateService;
        }
        [HttpGet("GetAllTemplate")]
        public ActionResult<IEnumerable<Template>> GetAll()
        {
            var result = _RATemplateService.GetAll().ToList();
            return result;
        }

    }
}





