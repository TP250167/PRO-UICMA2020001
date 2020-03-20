using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Request_For_EmployeeData;

namespace UICMA.Service.ClaimServices
{
   public interface IRequestForEmpDataService
    {
        RequestForEmployeeData AddandUpdateRequestForEmpData(RequestForEmployeeData request);
        IEnumerable<RequestForEmployeeData> GetRequestForEmpDataAll();
        RequestForEmployeeData GetRequestForEmpDatabyID(int Id);


    }
}
