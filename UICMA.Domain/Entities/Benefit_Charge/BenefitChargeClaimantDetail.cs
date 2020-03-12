using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Benefit_Charge;

namespace UICMA.Domain.Entities.Benefit_Charge_ClaimantDetail
{
   public class BenefitChargeClaimantDetail :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string ClaimantName { get; set; }
        public string ClaimantSSN { get; set; }
        public DateTime? ClaimDate { get; set; }
        public string ClaimType { get; set; }
        public string PCMCode { get; set; }
        public string ChargeCode { get; set; }
        public float? EmployerCharge { get; set; }
        public DateTime? ChargeQuarterDate { get; set; }
        public Int64 FormId { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Int64 ClaimId { get; set; }

        public BenefitCharge benefitCharge { get; set; } 
    }
}
