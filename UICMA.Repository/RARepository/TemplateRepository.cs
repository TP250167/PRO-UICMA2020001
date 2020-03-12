using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UICMA.Domain.Entities.Templates;

namespace UICMA.Repository.RARepository
{
   public class TemplateRepository : EntityBaseRepository<Template>, ITemplateRepository
    {

        private readonly UICMAContext context;
        public TemplateRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }

        public List<Template> GetTempalteByRule(string Category)
        {
            return context.Templates.Where(s => s.TemplateCategory == Category).ToList();
        }
    }
}
