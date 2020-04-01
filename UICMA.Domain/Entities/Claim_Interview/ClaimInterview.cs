using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;
using UICMA.Domain.Entities.Questions;

namespace UICMA.Domain.Entities.Claim_Interview
{
   public class ClaimInterview :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Address { get; set; }
        public DateTime? LAUSDFaxDate { get; set; }
        public DateTime? BYBClaimDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string ClaimantName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Status { get; set; }    
        public DateTime? Date { get; set; }
        public string Time { get; set; }
        public string DETInterviewer { get; set; }
        public string InterviewerPhoneNumber { get; set; }
        public string RepresentativeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Signature { get; set; }
        public string Title { get; set; }
        public string PrintName { get; set; }
        public DateTime? RepresentativeDate { get; set; }
        public Int64? IssuesList { get; set; }
        public string FormCode { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Int64 ClaimId { get; set; }
        public Claim claim { get; set; }
        public IEnumerable<Question> questions { get; set; }
    }
}



