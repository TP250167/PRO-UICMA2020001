using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Repository.ClaimRepository
{
  public interface INewClaimRepository : IEntityBaseRepository<Claim>
    {
        IEnumerable<Claim> GetActiveClaims(int Year);
        IEnumerable<Claim> GetExceptionClaims(int Year);
    }
}
