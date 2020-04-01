using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.ClaimExceptions;

namespace UICMA.Repository.ClaimRepository
{
   public interface IClaimExceptionRepository: IEntityBaseRepository<ClaimException>
    {

        List<ClaimException> GetClaimsByYear(int Year);

    }
}
