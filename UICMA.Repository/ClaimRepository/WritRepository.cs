using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Writs;

namespace UICMA.Repository.ClaimRepository
{
  public class WritRepository : EntityBaseRepository<Writ>, IWritRepository
    {
        private readonly UICMAContext context;
        public WritRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}