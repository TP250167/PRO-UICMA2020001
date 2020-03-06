using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.CUIAB_Acknowledgement
{
   public class CUIABAcknowledgement:IBaseEntity
    {
        public Int64 Id { get; set; }
        public string ClaimantName { get; set; }
        public string ABCaseNumber { get; set; }
        public string Appellant { get; set; }
        public string ALJDecisionNumber { get; set; }
        public DateTime? DateMailed { get; set; }
        public string CreatedBy { get; set; }
        public string AccountNumber { get; set; }
        public string Address { get; set; }
        public string LAUSDAddress { get; set; }
        public string CUIABAddress { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Int64 ClaimId { get; set; }
        public string FormCode { get; set; }
        public string FormPath { get; set; }
        public Claim claim { get; set; }
    }
}
