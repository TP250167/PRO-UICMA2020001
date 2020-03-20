using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Request_To_Reopen;

namespace UICMA.Service.ClaimServices
{
  public  interface IRequestToReopenService
    {
        RequestToReopen AddandUpdateRequestToReopen(RequestToReopen requestToReopen);
        IEnumerable<RequestToReopen> GetRequestToReopenAll();
        RequestToReopen GetRequestToReopenbyID(int Id);
    }
}
