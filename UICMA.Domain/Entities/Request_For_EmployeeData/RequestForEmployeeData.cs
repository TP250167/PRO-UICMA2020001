using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Request_For_EmployeeData
{
   public class RequestForEmployeeData :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string ClaimantName { get; set; }
        public string SocialSecurityNumber { get; set; }     
        public DateTime? BYBClaimDate { get; set; }
        public string Notes { get; set; }
        public DateTime? Date { get; set; }
        public string UserCompletedBy { get; set; }
        public string UserCompletedDate { get; set; }
        public string UserTitle { get; set; }
        public string UserTelephoneNumber { get; set; }
        public string FormCode { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Int64 ClaimId { get; set; }
        public Claim claim { get; set; }
    }
}
