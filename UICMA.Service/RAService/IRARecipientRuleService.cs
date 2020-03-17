using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RARecipientRules;

namespace UICMA.Service.RAService
{
    public interface IRARecipientRuleService
    {
        IEnumerable<RARecipientRule> GetAllRARecipientRule();
        List<RARecipientRule> GetAllRARecipientRuleByAnnual(bool Annual);
    }
}
