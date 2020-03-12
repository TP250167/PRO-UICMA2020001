using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.NoticeOfWages
{
   public class Wages :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string ClaimantName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string OtherSSN { get; set; }    
        public DateTime? ClaimDate { get; set; }
        public string FieldOfficePhoneNo { get; set; }
        public string FieldOfficeAddress { get; set; }
        public string Notes { get; set; }
        public DateTime? PostmarkedResponseDate { get; set; }
        public string WagesReport { get; set; }
        public string WagesQuarter1Date { get; set; }
        public string WagesQuarter2Date { get; set; }
        public string WagesQuarter3Date { get; set; }
        public string WagesQuarter4Date { get; set; }
        public string WagesQuarter1Amount { get; set; }
        public string WagesQuarter2Amount { get; set; }
        public string WagesQuarter3Amount { get; set; }
        public string WagesQuarter4Amount { get; set; }
        public string TotalWagesForEmployee { get; set; }
        public string TotalWagesForAllEmployees { get; set; }
        public string ClaimantWeeklyBenefitAmount { get; set; }
        public string BenefitChargeableReserveAccount { get; set; }
        public string FormCode { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Int64 ClaimId { get; set; }
        public Claim claim { get; set; }
    }
}
