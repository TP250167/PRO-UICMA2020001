using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RABatchRecipientRules;
using UICMA.Domain.Entities.RABatchs;

namespace UICMA.Domain.Entities.RARecipientRules
{
   public class RARecipientRule :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string RecipientRuleName { get; set; }
        public string RecipientRuleStatus { get; set; }
        public string RecipientRuleType { get; set; }
        public ICollection<RABatchRecipientRule> RAbatchRecipientRule { get; set; }
    }
}

