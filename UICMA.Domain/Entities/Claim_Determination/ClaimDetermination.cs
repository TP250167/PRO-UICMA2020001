using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Claim_Determination
{
   public class ClaimDetermination
    {
        public Int64 Id { get; set; }
        public string Decision { get; set; }
        public DateTime? MailedDate { get; set; }
        public string BenefitYearBegan { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string FieldOffice { get; set; }
        public string FormCode { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string FormPath { get; set; }
        public Int64 ClaimId { get; set; }

        public Claim claim { get; set; }
    }
}


