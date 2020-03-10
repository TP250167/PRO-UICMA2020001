using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UICMA.Domain.Entities.Claim_Interview;

namespace UICMA.Repository
{

    public class ClaimInterviewRepository : EntityBaseRepository<ClaimInterview>, IClaimInterviewRepository
    {
        private readonly UICMAContext context;
        public ClaimInterviewRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }



}
