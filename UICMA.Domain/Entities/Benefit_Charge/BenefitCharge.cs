using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Benefit_Charge_ClaimantDetail;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Benefit_Charge
{
   public class BenefitCharge :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string MaxAmountReceived { get; set; }
        public string ActualAmountPaid { get; set; }
        public string AmountPaidByBYB { get; set; }
        public DateTime? IssuedDate { get; set; }
        public string AmountPaidByFiscalYear { get; set; }
        public string AccountId { get; set; }
        public string Notes { get; set; }
        public Int64? LetterId { get; set; }
        public string FormCode { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Int64 ClaimId { get; set; }
        public Claim claim { get; set; }
        public IEnumerable<BenefitChargeClaimantDetail> benefitChargeClaimantDetail { get; set; }

    }
}
