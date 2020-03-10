using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Repository.ClaimRepository
{
    

    public class NewClaimRepository : EntityBaseRepository<Claim>, INewClaimRepository
    {
        private readonly UICMAContext context;
        public NewClaimRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
