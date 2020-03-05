using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Appeal;
using UICMA.Domain.Entities.Claim_Determination;
using UICMA.Domain.Entities.Claim_Interview;
using UICMA.Domain.Entities.Claim_Response;
using UICMA.Domain.Entities.Response_to_Employer;

namespace UICMA.Domain.Entities.New_Claim
{
   public class Claim
    {
        public Int64 Id { get; set; }
        public string RequestNumber { get; set; }
        public string Type { get; set; }
        public string RequestTitle { get; set; }
        public string ClaimantName { get; set; }
        public string CurrentStage { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string Gender { get; set; }
        public string EmployeeNumber { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string ReasonForSeparation { get; set; }
        public string NewClaim { get; set; }
        public string AdditionalClaim { get; set; }
        public int BenefitYearBeginning { get; set; }
        public DateTime? DateMailedToEDD { get; set; }
        public DateTime? MailDate { get; set; }
        public DateTime? EffectiveDateOfClaim { get; set; }
        public DateTime? LastDateWorked { get; set; }

        public ClaimResponse claimResponse { get; set; }
        public ClaimInterview claimInterview { get; set; }
        public ClaimDetermination claimDetermination { get; set; }
        public ResponseToEmployer responsetoEmployer { get; set; }
        public ClaimAppeal claimAppeal { get; set; }
    }
}
