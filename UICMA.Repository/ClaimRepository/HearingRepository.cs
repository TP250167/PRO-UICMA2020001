using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Hearings;

namespace UICMA.Repository.ClaimRepository
{
  public class HearingRepository : EntityBaseRepository<Hearing>, IHearingRepository
    {
        private readonly UICMAContext context;
        public HearingRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}