using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UICMA.Domain.Entities.Issues_List;
using UICMA.Service;
using UICMA.Service.ClaimServices;

namespace UICMA.API.Areas.Claims.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesListController : ControllerBase
    {
         private ILoggerManager _logger;
        private IMapper _mapper;
        private IIssuesListService _IssuesListService;

        public IssuesListController(ILoggerManager logger, IMapper mapper, IIssuesListService _IssuesListService)
        {
            _logger = logger;
            _mapper = mapper;
            this._IssuesListService = _IssuesListService;
        }

        [HttpPost("AddandUpdateIssuesList")]
        public IssuesList AddandUpdateIssuesList(IssuesList issuesList)
        {
            return _IssuesListService.AddandUpdateIssuesList(issuesList);
        }

        [HttpGet("GetIssuesListAll")]
        public ActionResult<IEnumerable<IssuesList>> GetIssuesListAll()

        {
            var result = _IssuesListService.GetIssuesListAll().ToList();
            return result;
        }

        [HttpGet("GetIssuesListbyID/{id}")]
        public ActionResult<IssuesList> GetIssuesListbyID(int id)
        {
            var results = _IssuesListService.GetIssuesListbyID(id);
            return results;
        }

    }
}