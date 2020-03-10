using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Issues_List;

namespace UICMA.Repository.ClaimRepository
{
   
    public class IssuesListRepository : EntityBaseRepository<IssuesList>, IIssuesListRepository
    {
        private readonly UICMAContext context;
        public IssuesListRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
