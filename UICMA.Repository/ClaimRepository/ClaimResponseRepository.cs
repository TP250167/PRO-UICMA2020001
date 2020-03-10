using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Response;

namespace UICMA.Repository
{


    public class ClaimResponseRepository : EntityBaseRepository<ClaimResponse>, IClaimResponseRepository
    {
        private readonly UICMAContext context;
        public ClaimResponseRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }

}
