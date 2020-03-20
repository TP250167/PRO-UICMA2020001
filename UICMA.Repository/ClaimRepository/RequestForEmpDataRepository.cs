using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Request_For_EmployeeData;

namespace UICMA.Repository.ClaimRepository
{
  public class RequestForEmpDataRepository: EntityBaseRepository<RequestForEmployeeData>, IRequestForEmpDataRepository
    {
        private readonly UICMAContext context;
    public RequestForEmpDataRepository(UICMAContext context) : base(context)
    {
        this.context = context;
    }
}
}
