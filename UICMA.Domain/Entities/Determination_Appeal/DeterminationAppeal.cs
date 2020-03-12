using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Determination_Appeal
{
   public class DeterminationAppeal :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string ClaimantName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string TranslatorLanguage { get; set; }
        public bool NeedTranslator { get; set; }
        public string EDDOfficeAddress { get; set; }
        public string AppellantAddress { get; set; }
        public string AppellantEmail { get; set; }
        public string AppellantFaxNo { get; set; }
        public string AppellantTelephoneNo { get; set; }
        public string AppellantCellNo { get; set; }
        public bool AuthorizeToSendEmail { get; set; }
        public bool AuthorizeToSendText { get; set; }
        public string EmployerAccountNumber { get; set; }
        public string AgentName { get; set; }
        public string AgentAddress { get; set; }
        public string AgentCity { get; set; }
        public string AppellantCity { get; set; }
        public string AgentState { get; set; }
        public string AgentZipcode { get; set; }
        public string AppellantState { get; set; }
        public string AppellantZipcode { get; set; }
        public DateTime? FormDate { get; set; }
        public string Notes { get; set; }
        public string Signature { get; set; }
        public string AppellantStatementNoticeDate { get; set; }
        public string AppellantStatementComments { get; set; }
        public string FormCode { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Int64 ClaimId { get; set; }
        public Claim claim { get; set; }
    }
}
