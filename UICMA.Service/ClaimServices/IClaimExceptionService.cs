using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities;
using UICMA.Domain.Entities.ClaimExceptions;

namespace UICMA.Service.ClaimServices
{
  public interface IClaimExceptionService
    {
        ClaimException AddandUpdateClaimException(ClaimException claimException);
        IEnumerable<ClaimException> GetClaimExceptionAll();
        ClaimException GetClaimExceptionbyID(int Id);

        ViewClaimException GetClaimException(int Year);

        //ClaimException GetReqNumClaims(string RequestNumber);
    }
}
