using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Wages_Appeal
{
   public class WagesAppeal :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string ClaimantName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string LAUSDEligibilityInformation { get; set; }
        public DateTime? BYBClaimDate { get; set; }
        public string FieldOfficeAddress { get; set; }
        public string Notes { get; set; }
        public DateTime? LAUSDFaxDate { get; set; }
        public string LAUSDAccountNumber { get; set; }
        public string UserName { get; set; }
        public string Signature { get; set; }
        public DateTime? Date { get; set; }
        public string UserPhoneNumber { get; set; }
        public string FormCode { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Int64 ClaimId { get; set; }
        public Claim claim { get; set; }
    }
}
