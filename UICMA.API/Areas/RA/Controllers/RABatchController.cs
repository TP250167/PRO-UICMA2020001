using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.RA.RAView;
using UICMA.Domain.Entities.RABatchs;
using UICMA.Domain.Entities.RARecipientRules;
using UICMA.Service;
using UICMA.Service.RAService;

namespace UICMA.API.Areas.RA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RABatchController : ControllerBase
    {

        private ILoggerManager _logger;
        private IMapper _mapper;
        private IRABatchService _RABatchService;
        

        public RABatchController(ILoggerManager logger, IMapper mapper, IRABatchService _RABatchService)
        {
            _logger = logger;
            _mapper = mapper;
            this._RABatchService = _RABatchService;
        }

        [HttpPost("CreateBatch")]
        public RABatchView CreateBatch(RABatchView Batch)
        {
            return _RABatchService.CreateBatch(Batch);
        }

        [HttpGet("GetAllRABatch")]
        public ActionResult<IEnumerable<RABatchView>> GetAllRABatch()
        {
            var result = _RABatchService.GetAllRABatch().ToList();
            return result;
        }

        [HttpGet("GetRABatchbyId/{id}")]
        public ActionResult<RABatchView> GetRABatchbyId(int id)
        {
            var results = _RABatchService.GetRABatchbyID(id);
            return results;
        }

        [HttpGet("GetBatchViewbyID/{Batchid}")]
        public RABatchViewModel GetBatchViewbyID(int Batchid)
        {
            return _RABatchService.GetBatchViewbyID(Batchid);
        }

        [HttpGet("GetRANotificationList/{Batchid}")]
        public List<RANotificationViewModel> GetRANotificationList(int Batchid)
        {
            return _RABatchService.GetRANotificationList(Batchid);
        }

        [HttpGet("GetAllRABiWeeklyBatch")]
        public ActionResult<IEnumerable<RABatchView>> GetAllRABiWeeklyBatch()
        {
            return _RABatchService.GetAllRABiWeeklyBatch().ToList();
           
        }
    }
}