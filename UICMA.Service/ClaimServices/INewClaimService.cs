using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Service.ClaimServices
{
  public  interface INewClaimService
    {
        Claim AddandUpdateNewClaim(Claim newClaim);
        IEnumerable<Claim> GetNewClaimAll();
        Claim GetNewclaimbyID(int Id);
    }
}
