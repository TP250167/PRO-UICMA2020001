using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities;
using UICMA.Domain.Entities.ClaimExceptions;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimExceptionController : ControllerBase
    {
     
            private ILoggerManager _logger;
            private IMapper _mapper;
            private IClaimExceptionService _ClaimExceptionService;

            public ClaimExceptionController(ILoggerManager logger, IMapper mapper, IClaimExceptionService _ClaimExceptionService)
            {
                _logger = logger;
                _mapper = mapper;
                this._ClaimExceptionService = _ClaimExceptionService;
            }

            [HttpPost("AddandUpdateClaimException")]
            public ClaimException AddandUpdateClaimException(ClaimException newClaimException)
            {
                return _ClaimExceptionService.AddandUpdateClaimException(newClaimException);
            }

            [HttpGet("GetClaimExceptionAll")]
            public ActionResult<IEnumerable<ClaimException>> GetClaimExceptionAll()

            {
                var result = _ClaimExceptionService.GetClaimExceptionAll().ToList();
                return result;
            }

            [HttpGet("GetClaimExceptionbyID/{id}")]
            public ActionResult<ClaimException> GetClaimExceptionbyID(int id)
            {
                var results = _ClaimExceptionService.GetClaimExceptionbyID(id);
                return results;
            }


        [HttpGet("GetClaimException/{Year}")]
        public ActionResult<ViewClaimException> GetClaimException(int Year)
            {
            var result = _ClaimExceptionService.GetClaimException(Year);
            return result;
        }


       


    }
    }
