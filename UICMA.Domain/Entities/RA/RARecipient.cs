using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RAAssociatedDocuments;
using UICMA.Domain.Entities.RABatchRecipients;

namespace UICMA.Domain.Entities.RARecipients
{
   public class RARecipient :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmailReferenceNumber { get; set; }
        public string Status { get; set; }
        public DateTime? NotifiedSentOn { get; set; }
        public DateTime? DeliveredOn { get; set; }
        public DateTime? FailedOn { get; set; }
        public string DeliveryNotice { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? RetrySucess { get; set; }
        public int? RetryFail { get; set; }
        public bool IsRetry { get; set; }
        public bool IsSucessfullyDeliver { get; set; }
        public bool IsDeliveryMailCaptured { get; set; }
        public bool IsSentMailCaptured { get; set; }
        public ICollection<RAAssociatedDocument> RAassociatedDocument { get; set; }
        public ICollection<RABatchRecipient> RAbatchRecipient { get; set; }
    }
}



