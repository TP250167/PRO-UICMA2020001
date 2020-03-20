using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Benefit_Charge;

namespace UICMA.Repository.ClaimRepository
{
   public class BenefitChargeRepository : EntityBaseRepository<BenefitCharge>, IBenefitChargeRepository
    {
        private readonly UICMAContext context;
        public BenefitChargeRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
  