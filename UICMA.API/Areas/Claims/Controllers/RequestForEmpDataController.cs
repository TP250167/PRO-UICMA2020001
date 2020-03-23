using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Request_For_EmployeeData;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   public class RequestForEmpDataController : ControllerBase
{
    private ILoggerManager _logger;
    private IMapper _mapper;
    private IRequestForEmpDataService _RequestForEmpData;

    public RequestForEmpDataController(ILoggerManager logger, IMapper mapper, IRequestForEmpDataService _RequestForEmpData)
    {
        _logger = logger;
        _mapper = mapper;
        this._RequestForEmpData = _RequestForEmpData;
    }

    [HttpPost("AddandUpdateRequestForEmpData")]
    public RequestForEmployeeData AddandUpdateRequestForEmpData(RequestForEmployeeData cuiaAck)
    {
        return _RequestForEmpData.AddandUpdateRequestForEmpData(cuiaAck);
    }

    [HttpGet("GetRequestForEmpDataAll")]
    public ActionResult<IEnumerable<RequestForEmployeeData>> GetRequestForEmpDataAll()
    {

        var result = _RequestForEmpData.GetRequestForEmpDataAll().ToList();
        return result;
    }

    [HttpGet("GetRequestForEmpDatabyID/{id}")]
    public ActionResult<RequestForEmployeeData> GetRequestForEmpDatabyID(int id)
    {
        var results = _RequestForEmpData.GetRequestForEmpDatabyID(id);
        return results;
    }

}
}