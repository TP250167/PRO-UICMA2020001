using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Request_To_Reopen
{
   public class RequestToReopen :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string ClaimantName { get; set; }
        public string AccountNumber { get; set; }
        public string CaseNumber { get; set; }
        public DateTime? MailDate { get; set; }
        public string HearingTime { get; set; }
        public string Signature { get; set; }
        public string Employer { get; set; }
        public string RequestReason { get; set; }
        public string AppealOfficeAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public DateTime? HearingDate { get; set; }
        public Int64? AdministrativeLawJudgeServer { get; set; }
        public string FormCode { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Int64 ClaimId { get; set; }
        public Claim claim { get; set; }

    }
}


