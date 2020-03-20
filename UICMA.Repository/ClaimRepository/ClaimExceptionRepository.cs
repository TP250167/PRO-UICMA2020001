using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.ClaimExceptions;

namespace UICMA.Repository.ClaimRepository
{
    public class ClaimExceptionRepository : EntityBaseRepository<ClaimException>, IClaimExceptionRepository
    {
        private readonly UICMAContext context;
        public ClaimExceptionRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
