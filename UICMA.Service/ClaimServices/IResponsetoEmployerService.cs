using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Response_to_Employer;

namespace UICMA.Service.ClaimServices
{
   public interface IResponsetoEmployerService
    {
        ResponseToEmployer AddandUpdateResponseToEmployer(ResponseToEmployer responsetoEmployer);
        IEnumerable<ResponseToEmployer> GetResponseToEmployerAll();
        ResponseToEmployer GetResponseToEmployerbyID(int Id);

    }
}
