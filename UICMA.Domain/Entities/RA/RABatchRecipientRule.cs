using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RABatchs;
using UICMA.Domain.Entities.RARecipientRules;

namespace UICMA.Domain.Entities.RABatchRecipientRules
{
   public class RABatchRecipientRule:IBaseEntity
    {
        public Int64 Id { get; set; }
        public Int64 BatchId { get; set; }
        public Int64 RecipientRuleId { get; set; }

        public RABatch RAbatch { get; set; }
        public RARecipientRule RArecipientRule { get; set; }
    }
}
