using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLog;
using UICMA.Service;

namespace UICMA.API.Controllers.Administration

{
    [Route("api/schedule")]
    public class ScheduleController : Controller
    {
        private ILoggerManager _logger;
        private IMapper _mapper;

        public ScheduleController(ILoggerManager logger,IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]        
        public IActionResult GetAllSchedules()
        {
            return null;
        }
        [HttpGet("{id}")]
        public IActionResult GetScheduleById(int id)
        {
            return null;
        }
    }
}