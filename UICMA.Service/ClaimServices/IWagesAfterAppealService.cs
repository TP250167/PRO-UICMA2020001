using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Wages_After_Appeal;

namespace UICMA.Service.ClaimServices
{
  public interface IWagesAfterAppealService
    {
        WagesAfterAppeal AddandUpdateWagesAfterAppeal(WagesAfterAppeal claimAppeal);
        IEnumerable<WagesAfterAppeal> GetWagesAfterAppealAll();
        WagesAfterAppeal GetWagesAfterAppealbyID(int Id);

    }
}
