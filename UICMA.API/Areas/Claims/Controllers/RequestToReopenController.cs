using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Request_To_Reopen;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RequestToReopenController : ControllerBase
    {

        private ILoggerManager _logger;
        private IMapper _mapper;
        private IRequestToReopenService _RequestToReopen;

        public RequestToReopenController(ILoggerManager logger, IMapper mapper, IRequestToReopenService _RequestToReopen)
        {
            _logger = logger;
            _mapper = mapper;
            this._RequestToReopen = _RequestToReopen;
        }

        [HttpPost("AddandUpdateRequestToReopen")]
        public RequestToReopen AddandUpdateRequestToReopen(RequestToReopen requestToReopen)
        {
            return _RequestToReopen.AddandUpdateRequestToReopen(requestToReopen);
        }

        [HttpGet("GetRequestToReopenAll")]
        public ActionResult<IEnumerable<RequestToReopen>> GetRequestToReopenAll()

        {
            var result = _RequestToReopen.GetRequestToReopenAll().ToList();
            return result;
        }

        [HttpGet("GetRequestToReopenbyID/{id}")]
        public ActionResult<RequestToReopen> GetRequestToReopenbyID(int id)
        {
            var results = _RequestToReopen.GetRequestToReopenbyID(id);
            return results;
        }

    }
}