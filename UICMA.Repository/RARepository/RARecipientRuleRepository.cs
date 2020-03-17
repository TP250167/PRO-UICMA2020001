using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UICMA.Domain.Entities.RARecipientRules;

namespace UICMA.Repository.RARepository
{
    public class RARecipientRuleRepository : EntityBaseRepository<RARecipientRule>, IRARecipientRuleRepository
    {
        private readonly UICMAContext context;
        public RARecipientRuleRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
        
        public List<RARecipientRule> GetAllRARecipientRuleByAnnual(bool Annual)
        {
            return context.RARecipientRule.Where(s => s.IsAnnual == Annual).ToList();
        }
    }
}



