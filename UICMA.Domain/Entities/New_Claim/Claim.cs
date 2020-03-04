﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Domain.Entities.New_Claim
{
   public class Claim
    {
        public Int64 Id { get; set; }
        public string RequestNumber { get; set; }
        public string Type { get; set; }
        public string RequestTitle { get; set; }
        public string ClaimantName { get; set; }
        public string CurrentStage { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string Gender { get; set; }
        public string EmployeeNumber { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string ReasonForSeparation { get; set; }
        public string NewClaim { get; set; }
        public string AdditionalClaim { get; set; }
        public int BenefitYearBeginning { get; set; }
        public DateTime? DateMailedToEDD { get; set; }
        public DateTime? MailDate { get; set; }
        public DateTime? EffectiveDateOfClaim { get; set; }
        public DateTime? LastDateWorked { get; set; }
    }
}
