using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Claim_Appeal
{
   public class ClaimAppeal :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string FormCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public DateTime? LAUSDFaxDate { get; set; }
        public DateTime? BYBClaimDate { get; set; }
        public DateTime? FormDate { get; set; }
        public string LAUSDAccountNumber { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string ClaimantName { get; set; }
        public string LAUSDEligibilityInformation { get; set; }
        public string RepresentativeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Signature { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Int64 ClaimId { get; set; }

        public Claim claim { get; set; }
    }
}






