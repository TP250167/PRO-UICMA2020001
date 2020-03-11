using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Response_to_Employer;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponsetoEmployerController : ControllerBase
    {

        private ILoggerManager _logger;
        private IMapper _mapper;
        private IResponsetoEmployerService _ResponsetoEmployer;

        public ResponsetoEmployerController(ILoggerManager logger, IMapper mapper, IResponsetoEmployerService _ResponsetoEmployer)
        {
            _logger = logger;
            _mapper = mapper;
            this._ResponsetoEmployer = _ResponsetoEmployer;
        }

        [HttpPost("AddandUpdateResponseToEmployer")]
        public ResponseToEmployer AddandUpdateResponseToEmployer(ResponseToEmployer responsetoEmployer)
        {
            return _ResponsetoEmployer.AddandUpdateResponseToEmployer(responsetoEmployer);
        }

        [HttpGet("GetResponseToEmployerAll")]
        public ActionResult<IEnumerable<ResponseToEmployer>> GetResponseToEmployerAll()

        {
            var result = _ResponsetoEmployer.GetResponseToEmployerAll().ToList();
            return result;
        }

        [HttpGet("GetResponseToEmployerbyID/{id}")]
        public ActionResult<ResponseToEmployer> GetResponseToEmployerbyID(int id)
        {
            var results = _ResponsetoEmployer.GetResponseToEmployerbyID(id);
            return results;
        }


    }
}