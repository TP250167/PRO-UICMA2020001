using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Wages_Appeal;

namespace UICMA.Service.ClaimServices
{
  public interface IWagesAppealService
    {
        WagesAppeal AddandUpdateWagesAppeal(WagesAppeal wagesAppeal);
        IEnumerable<WagesAppeal> GetWagesAppealAll();
        WagesAppeal GetWagesAppealbyID(int Id);

    }
}
