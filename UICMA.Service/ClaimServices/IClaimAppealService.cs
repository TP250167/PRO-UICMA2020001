using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Appeal;

namespace UICMA.Service
{
  public  interface IClaimAppealService
    {

        ClaimAppeal AddandUpdateclaimAppeal(ClaimAppeal claimAppeal);
        IEnumerable<ClaimAppeal> GetclaimAppealAll();
        ClaimAppeal GetclaimAppealbyID(int Id);
    }
}
