using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Hearings
{
  public  class Hearing:IBaseEntity
    {
       public Int64 Id { get; set; }
        public string ClaimantName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string CaseNumber { get; set; }
        public DateTime? MailDate { get; set; }
        public string HearingTime { get; set; }
        public string HearingPlace { get; set; }
        public bool AppellantType { get; set; }
        public string AppellantName { get; set; }
        public string Notes { get; set; }
        public string AdministrativeLawJudge { get; set; }
        public string EDDOffice { get; set; }
        public DateTime? HearingDate { get; set; }
        public Int64? IssuesList { get; set; }
        public string FormCode { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Int64 ClaimId { get; set; }
        public Claim claim { get; set; }
    }
}
