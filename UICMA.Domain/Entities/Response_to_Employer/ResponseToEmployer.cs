using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Response_to_Employer
{
   public class ResponseToEmployer :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string ClaimantName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public DateTime? DateMailed { get; set; }
        public DateTime? BenefitYearBeganDate { get; set; }
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
