using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.ALJ_Decision;

namespace UICMA.Repository.ClaimRepository
{
  


    public class ALJDecisionRepository : EntityBaseRepository<ALJDecision>, IALJDecisionRepository
    {
        private readonly UICMAContext context;
        public ALJDecisionRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }

}
