using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.BoardDecisions
{
   public class BoardDecision :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string PartiesAppearing { get; set; }
        public string Decision { get; set; }
        public string CaseNumber { get; set; }
        public DateTime? MailDate { get; set; }
        public DateTime? BYBClaimDate { get; set; }
        public DateTime? ApplicationReopenDate { get; set; }
        public string ClaimantName { get; set; }
        public string EmployerInfo { get; set; }
        public string ALJName { get; set; }
        public DateTime? PlaceOfHearingDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Int64 ClaimId { get; set; }
        public string FormCode { get; set; }
        public string FormPath { get; set; }
        public Claim claim { get; set; }
    }
}
