using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.RA.RAView;
using UICMA.Domain.Entities.RARecipients;
using UICMA.Service;
using UICMA.Service.RAService;

namespace UICMA.API.Areas.RA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RARecipientController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IRARecipientService _RARecipientService;

        public RARecipientController(ILoggerManager logger, IMapper mapper, IRARecipientService _RARecipientService)
        {
            _logger = logger;
            _mapper = mapper;
            this._RARecipientService = _RARecipientService;
        }

      
        [HttpGet("GetAllRARecipient")]
        public ActionResult<IEnumerable<RARecipient>> GetAllRARecipient()
        {
            var result = _RARecipientService.GetAllRARecipient().ToList();
            return result;
        }

        [HttpGet("GetRARecipientbyID/{id}")]
        public ActionResult<RARecipient> GetRARecipientbyID(int id)
        {
            var results = _RARecipientService.GetRARecipientbyID(id);
            return results;
        }

        [HttpGet("GetRARecipientbyBatchID/{id}")]
        public ActionResult<RARecipient> GetRARecipientbyBatchID(int id)
        {
            var results = _RARecipientService.GetRARecipientbyBatchID(id);
            return results;
        }

        [HttpGet("DeleteRARecipientId/{id}")]
        public ActionResult<RARecipient> DeleteRARecipientId(int id)
        {
            var results = _RARecipientService.DeleteRARecipientId(id);
            return results;
        }
        [HttpGet("GetAllRARecipient/{Batchid}")]
        public List<RARecipientView> GetAllRecipient(int Batchid)
        {
            var results = _RARecipientService.GetAllRecipient(Batchid);
            return results;          
        }

        [HttpGet("GetAllDeliverdRecipient/{Batchid}")]
        public List<RARecipientView> GetAllDeliverdRecipient(int Batchid)
        {
            var results = _RARecipientService.GetAllDeliverdRecipient(Batchid);
            return results;
        }
        [HttpGet("GetAllFailedRecipient/{Batchid}")]
        public List<RARecipientView> GetAllFailedRecipient(int Batchid)
        {
            var results = _RARecipientService.GetAllFailedRecipient(Batchid);
            return results;
        }      
    }
}