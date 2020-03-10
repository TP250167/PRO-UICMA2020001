using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Interview;

namespace UICMA.Service
{
   public interface IClaimInterviewService
    {
        ClaimInterview AddandUpdateClaimInterview(ClaimInterview claimInterview);
        IEnumerable<ClaimInterview> GetClaimInterviewAll();
        ClaimInterview GetClaimInterviewbyID(int Id);

    }
}
