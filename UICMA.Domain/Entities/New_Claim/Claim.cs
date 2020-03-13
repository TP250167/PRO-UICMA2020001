using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Additional_Information;
using UICMA.Domain.Entities.ALJ_Decision;
using UICMA.Domain.Entities.Benefit_Audit;
using UICMA.Domain.Entities.Benefit_Charge;
using UICMA.Domain.Entities.Claim_Appeal;
using UICMA.Domain.Entities.Claim_Determination;
using UICMA.Domain.Entities.Claim_Interview;
using UICMA.Domain.Entities.Claim_Response;
using UICMA.Domain.Entities.CUIAB_Acknowledgement;
using UICMA.Domain.Entities.CUIAB_Board_Appeal;
using UICMA.Domain.Entities.Determination_Appeal;
using UICMA.Domain.Entities.Hearings;
using UICMA.Domain.Entities.NoticeOfWages;
using UICMA.Domain.Entities.Request_For_EmployeeData;
using UICMA.Domain.Entities.Request_To_Reopen;
using UICMA.Domain.Entities.Response_to_Employer;
using UICMA.Domain.Entities.Wages_After_Appeal;
using UICMA.Domain.Entities.Wages_Appeal;
using UICMA.Domain.Entities.Writs;

namespace UICMA.Domain.Entities.New_Claim
{
    public class Claim:IBaseEntity
    {
        //internal object additionalInformation;

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
        public string Address { get; set; }
        public string ProtestDecision { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public string ClaimantStatus { get; set; }
        public string BYB { get; set; }

        public ClaimResponse claimResponse { get; set; }
        public ClaimInterview claimInterview { get; set; }
        public ClaimDetermination claimDetermination { get; set; }
        public ResponseToEmployer responsetoEmployer { get; set; }
        public ClaimAppeal claimAppeal { get; set; }
        public ALJDecision ALJdecision { get; set; }
        public CUIABAcknowledgement acknowledgement { get; set; }
        public WagesAfterAppeal  wagesAfterAppeal {get;set;}
        public AdditionalInformation additionalInformation { get; set; }
        public Hearing hearing { get; set; }
        public BenefitAudit benefitAudit { get; set; }
        public Writ writ { get; set; }
        public RequestToReopen requestToReopen { get; set; }
        public BenefitCharge benefitCharge { get; set; }
        public DeterminationAppeal determinationAppeal { get; set; }
        public Wages wages { get; set; } 
        public WagesAppeal wagesAppeal { get; set; }
        public RequestForEmployeeData requestForEmployeeData { get; set; }
        public CUIABBoardAppeal CUIABboardAppeal { get; set; }
    }
}
