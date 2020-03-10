using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Wages_After_Appeal;

namespace UICMA.Repository.ClaimRepository
{
   
    public class WagesAfterAppealRepository : EntityBaseRepository<WagesAfterAppeal>, IWagesAfterAppealRepository
    {
        private readonly UICMAContext context;
        public WagesAfterAppealRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
