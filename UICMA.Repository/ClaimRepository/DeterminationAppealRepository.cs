using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Determination_Appeal;

namespace UICMA.Repository.ClaimRepository
{
  public class DeterminationAppealRepository : EntityBaseRepository<DeterminationAppeal>, IDeterminationAppealRepository
    {
        private readonly UICMAContext context;
        public DeterminationAppealRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }

}