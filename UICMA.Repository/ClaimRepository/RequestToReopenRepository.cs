using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Request_To_Reopen;

namespace UICMA.Repository.ClaimRepository
{
  public  class RequestToReopenRepository : EntityBaseRepository<RequestToReopen>, IRequestToReopenRepository
    {
        private readonly UICMAContext context;
        public RequestToReopenRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
