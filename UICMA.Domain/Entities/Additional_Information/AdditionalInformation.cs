using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Additional_Information
{
   public class AdditionalInformation :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string ClaimantName { get; set; }
        public DateTime? MailDate { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string ControlNumber { get; set; }
        public DateTime? ClaimEffectiveDate { get; set; }
        public string EmployerName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmployerAddress { get; set; }
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

