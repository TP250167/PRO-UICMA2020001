using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Benefit_Audit;

namespace UICMA.Repository.ClaimRepository
{
  public class BenefitAuditRepository : EntityBaseRepository<BenefitAudit>, IBenefitAuditRepository
    {
        private readonly UICMAContext context;
        public BenefitAuditRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
