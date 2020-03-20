using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Wages_Appeal;

namespace UICMA.Repository.ClaimRepository
{
   public class WagesAppealRepository : EntityBaseRepository<WagesAppeal>, IWagesAppealRepository
    {
        private readonly UICMAContext context;
        public WagesAppealRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
