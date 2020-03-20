using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Benefit_Charge;

namespace UICMA.Service.ClaimServices
{
 public interface IBenefitChargeService
    {

        BenefitCharge AddandUpdateBenefitCharge(BenefitCharge benefitCharge);
        IEnumerable<BenefitCharge> GetBenefitChargeAll();
        BenefitCharge GetBenefitChargebyID(int Id);
    }
}
