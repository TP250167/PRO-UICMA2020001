using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Appeal;

namespace UICMA.Repository
{
   //public class ClaimAppealRepository:IClaimAppealRepository
   // {
   // }


    public class ClaimAppealRepository : EntityBaseRepository<ClaimAppeal>, IClaimAppealRepository
    {
        private readonly UICMAContext context;
        public ClaimAppealRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }


}
