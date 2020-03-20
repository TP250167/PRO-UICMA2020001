using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Determination_Appeal;

namespace UICMA.Service.ClaimServices
{
  public interface IDeterminationAppealService
    {

        DeterminationAppeal AddandUpdateDeterminationAppeal(DeterminationAppeal Determination);
            IEnumerable<DeterminationAppeal> GetDeterminationAppealAll();
             DeterminationAppeal GetDeterminationAppealbyID(int Id);

    }
}
