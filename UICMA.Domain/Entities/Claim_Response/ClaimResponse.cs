using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Claim_Response
{
   public class ClaimResponse :IBaseEntity
    {
        public Int64 Id { get; set; }
        public Int64 ClaimId { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string Address { get; set; }
        public DateTime? LAUSDMailDate { get; set; }
        public DateTime? BYBClaimDate { get; set; }
        public DateTime? EffectiveDateOfClaim { get; set; }
        public DateTime? DueDate { get; set; }
        public string ClaimantName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string LAUSDResponse { get; set; }
        public string RepresentativeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Signature { get; set; }
        public string Title { get; set; }
        public DateTime? Date { get; set; }
        public Int64? IssuesList { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool RALetter { get; set; }
        public bool ProtestPage { get; set; }
        public bool EEContract { get; set; }
        public bool TimeWageReport { get; set; }
        public bool StatementOfCharges { get; set; }
        public bool OfferLetter { get; set; }
        public bool SubCalender { get; set; }
        public bool WarningLetters { get; set; }
        public bool Other { get; set; }
        public string FormCode { get; set; }
        public Claim claim { get; set; }
        

    }
}


