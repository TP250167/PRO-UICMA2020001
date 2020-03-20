using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Benefit_Audit;

namespace UICMA.Service.ClaimServices
{
   public interface IBenefitAuditService
    {
        BenefitAudit AddandUpdateBenefitAudit(BenefitAudit benefitAudit);
        IEnumerable<BenefitAudit> GetBenefitAuditAll();
        BenefitAudit GetBenefitAuditbyID(int Id);
    }
}
