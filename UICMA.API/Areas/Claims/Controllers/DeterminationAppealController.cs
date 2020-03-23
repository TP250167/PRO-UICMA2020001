using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Determination_Appeal;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class DeterminationAppealController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IDeterminationAppealService _DeterminationAppeal;

        public DeterminationAppealController(ILoggerManager logger, IMapper mapper, IDeterminationAppealService _DeterminationAppeal)
        {
            _logger = logger;
            _mapper = mapper;
            this._DeterminationAppeal = _DeterminationAppeal;
        }

        [HttpPost("AddandUpdateDeterminationAppeal")]
        public DeterminationAppeal AddandUpdateDeterminationAppeal(DeterminationAppeal cuiaAck)
        {
            return _DeterminationAppeal.AddandUpdateDeterminationAppeal(cuiaAck);
        }

        [HttpGet("GetDeterminationAppealAll")]
        public ActionResult<IEnumerable<DeterminationAppeal>> GetDeterminationAppealAll()
        {

            var result = _DeterminationAppeal.GetDeterminationAppealAll().ToList();
            return result;
        }

        [HttpGet("GetDeterminationAppealbyID/{id}")]
        public ActionResult<DeterminationAppeal> GetDeterminationAppealbyID(int id)
        {
            var results = _DeterminationAppeal.GetDeterminationAppealbyID(id);
            return results;
        }

    }
}





