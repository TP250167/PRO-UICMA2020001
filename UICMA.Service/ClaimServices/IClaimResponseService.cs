using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Response;

namespace UICMA.Service
{
  public interface IClaimResponseService
    {

        ClaimResponse AddandUpdateClaimResponse(ClaimResponse claimResponse);
        IEnumerable<ClaimResponse> GetClaimResponseAll();
        ClaimResponse GetClaimResponsebyID(int Id);



    }
}
