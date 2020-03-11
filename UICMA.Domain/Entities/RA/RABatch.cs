using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RABatchRecipientRules;
using UICMA.Domain.Entities.RABatchRecipients;
using UICMA.Domain.Entities.RABatchSchedules;
using UICMA.Domain.Entities.RABatchTemplates;
using UICMA.Domain.Entities.RARecipientRules;

namespace UICMA.Domain.Entities.RABatchs
{
   public class RABatch :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string BatchName { get; set; }
        public string BatchDescription { get; set; }
        public string Frequency { get; set; }
        public bool IsRecuring { get; set; }
        public string Occurrance { get; set; }
        public string Status { get; set; }
        public string Time { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? NextOccurrance { get; set; }
        public ICollection<RABatchRecipientRule> RAbatchRecipientRule { get; set; }
        public ICollection<RABatchSchedule> RAbatchSchedule { get; set; }
        public ICollection<RABatchTemplate> RAbatchTemplate { get; set; }
        public ICollection<RABatchRecipient> RAbatchRecipient { get; set; }
    }
}


