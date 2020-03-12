using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RABatchRecipientRules;

namespace UICMA.Repository.RARepository
{
    public class RABatchRecipientRuleRepository : EntityBaseRepository<RABatchRecipientRule>, IRABatchRecipientRuleRepository
    {
        private readonly UICMAContext context;
        public RABatchRecipientRuleRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}