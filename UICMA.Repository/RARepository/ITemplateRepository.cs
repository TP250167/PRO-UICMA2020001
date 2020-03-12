using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Templates;

namespace UICMA.Repository.RARepository
{
    public interface ITemplateRepository : IEntityBaseRepository<Template>
    {
        List<Template> GetTempalteByRule(string Category);
    }
}
