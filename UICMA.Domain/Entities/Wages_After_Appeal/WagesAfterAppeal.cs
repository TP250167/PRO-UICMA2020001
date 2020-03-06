using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Wages_After_Appeal
{
   public class WagesAfterAppeal:IBaseEntity
    {
        public Int64 Id { get; set; }
        public string ClaimantName { get; set; }
        public DateTime? MailingDate { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string CaseNumber { get; set; }
        public DateTime? DeadLineDate { get; set; }
        public string PreparerName { get; set; }
        public string TelephoneNumber { get; set; }
        public string FaxNumber { get; set; }
        //public string AccountID { get; set; }
        //public DateTime? FirstDayWorked { get; set; }
        //public DateTime? LastDayWorked { get; set; }
        //public DateTime? TerminationDate { get; set; }
        //public bool HasWagesSubject { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public Int64 ClaimId { get; set; }
        public string FormCode { get; set; }
        public string FormPath { get; set; }
        public Claim claim { get; set; }
    }
}
