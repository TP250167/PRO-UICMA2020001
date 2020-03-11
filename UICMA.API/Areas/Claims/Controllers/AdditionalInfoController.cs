using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Additional_Information;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    

    public class AdditionalInfoController : ControllerBase
    {
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IAdditionalInfoService _AdditionalInfoService;

        public AdditionalInfoController(ILoggerManager logger, IMapper mapper, IAdditionalInfoService _AdditionalInfoService)
        {
            _logger = logger;
            _mapper = mapper;
            this._AdditionalInfoService = _AdditionalInfoService;
        }

        [HttpPost("AddandUpdateAdditionalInfo")]
        public AdditionalInformation AddandUpdateAdditionalInfo(AdditionalInformation additionalInfor)
        {
            return _AdditionalInfoService.AddandUpdateAdditionalInfo(additionalInfor);
        }

        [HttpGet("GetAdditionalInfoAll")]
        public ActionResult <IEnumerable<AdditionalInformation>> GetAdditionalInfoAll()
            
        {
            var result = _AdditionalInfoService.GetAdditionalInfoAll().ToList();
            return result;
        }

        [HttpGet("GetAdditionalInfobyID/{id}")]
        public ActionResult<AdditionalInformation> GetAdditionalInfobyID(int id)
        {
            var results = _AdditionalInfoService.GetAdditionalInfobyID(id);
            return results;
        }


    }







}