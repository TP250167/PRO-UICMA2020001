using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Determination;

namespace UICMA.Repository
{



    public class ClaimDeterminationRepository : EntityBaseRepository<ClaimDetermination>, IClaimDeterminationRepository
    {
        private readonly UICMAContext context;
        public ClaimDeterminationRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
    
}
