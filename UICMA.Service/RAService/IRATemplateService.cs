using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Templates;

namespace UICMA.Service.RAService
{
    public interface IRATemplateService
    {
        IEnumerable<Template> GetAll();
    }
}
