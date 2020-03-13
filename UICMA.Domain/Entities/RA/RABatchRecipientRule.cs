using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using UICMA.Domain.Entities.RABatchs;
using UICMA.Domain.Entities.RARecipientRules;

namespace UICMA.Domain.Entities.RABatchRecipientRules
{
    public class RABatchRecipientRule : IBaseEntity
    {
        public Int64 Id { get; set; }
        public Int64 BatchId { get; set; }
        public Int64 RecipientRuleId { get; set; }
        [NotMapped]

        public string RecipientRuleListId { get; set; }
        [NotMapped]
        public String RecipientRuleName { get; set; }
        [NotMapped]
        public String RecipientRule { get; set; }
        public RABatchView RAbatch { get; set; }
        public RARecipientRule RArecipientRule { get; set; }
    }
}
