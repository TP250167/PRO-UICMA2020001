using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Determination;

namespace UICMA.Service
{
  public  interface IClaimDeterminationService
    {

        ClaimDetermination AddandUpdateClaimDetermination(ClaimDetermination ClaimDetermination);
        IEnumerable<ClaimDetermination> GetClaimDeterminationAll();
        ClaimDetermination GetClaimDeterminationbyID(int Id);


    }
}
