using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Issues_List;

namespace UICMA.Service.ClaimServices
{
   public interface IIssuesListService
    {
        IssuesList AddandUpdateIssuesList(IssuesList issuesList);
        IEnumerable<IssuesList> GetIssuesListAll();
        IssuesList GetIssuesListbyID(int Id);

    }
}
