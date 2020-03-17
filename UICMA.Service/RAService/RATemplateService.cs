using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Templates;
using UICMA.Repository.RARepository;

namespace UICMA.Service.RAService
{
    public class RATemplateService: IRATemplateService
    {
        private ITemplateRepository _TemplateRepository;
        public RATemplateService(ITemplateRepository _TemplateRepository)
        {
            this._TemplateRepository = _TemplateRepository;
        }
        public IEnumerable<Template> GetAll()
        {
            return _TemplateRepository.GetAll();
        }
    }
}

