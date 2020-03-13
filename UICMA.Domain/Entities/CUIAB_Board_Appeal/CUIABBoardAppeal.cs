using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.CUIAB_Board_Appeal
{
   public class CUIABBoardAppeal
    {
        public Int64 Id { get; set; }
        public string ClaimantName { get; set; }
        public string CaseNumber { get; set; }
        public string AppealStatement { get; set; }
        public string SocialSecurityNumber { get; set; }
        public DateTime? BYBClaimDate { get; set; }    
        public string LAUSDAccountNumber { get; set; }
        public string CUIABAddress { get; set; }
        public string UserSignature { get; set; }
        public string UserTitle { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserPrintName { get; set; }
        public DateTime? LAUSDFaxDate { get; set; }
        public DateTime? UserDate { get; set; }
        public string AppellantName { get; set; }
        public string AppellantPhoneNumber { get; set; }
        public string AppellantFaxNumber { get; set; }
        public string AppellantMailAddress { get; set; }
        public string ALJDecisionCaseNumber { get; set; }
        public DateTime? ALJDecisionDate { get; set; }
        public bool CUIABPermission { get; set; }
        public string LAUSDEmailAddress { get; set; }       
        public string CellPhoneNumber { get; set; }
        public string EmployerAccountNumber { get; set; }
        public string AppellantAgentRepName { get; set; }
        public string AppellantAgentRepAddress { get; set; }
        public string DisagreeReason { get; set; }
        public string AppellantAgentRepSignature { get; set; }
        public DateTime? AppellantAgentRepSignedDate { get; set; }
        public DateTime? PartyFilingAppeal { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Int64 ClaimId { get; set; }
        public string FormCode { get; set; }
        public string FormPath { get; set; }
        public string Notes { get; set; }
        public Claim claim { get; set; }
    }
}
