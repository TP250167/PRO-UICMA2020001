using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.ALJ_Decision;

namespace UICMA.Service.ClaimServices
{
   public interface IALJDecisionService
    {
        ALJDecision AddandUpdateALJDecision(ALJDecision aljDecision);
            IEnumerable<ALJDecision> GetALJDecisionAll();
            ALJDecision GetALJDecisionbyID(int Id);
    }
}
