using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RARecipientRules;
using UICMA.Repository.RARepository;

namespace UICMA.Service.RAService
{
    public class RARecipientRuleService : IRARecipientRuleService
    {
        private IRARecipientRuleRepository _RARecipientRuleRepository;

        public RARecipientRuleService(IRARecipientRuleRepository _RARecipientRuleRepository)
        {
            this._RARecipientRuleRepository = _RARecipientRuleRepository;

        }

        //Get AllRARecipient
        public IEnumerable<RARecipientRule> GetAllRARecipientRule()
        {
            return _RARecipientRuleRepository.GetAll();
        }
    }
}




