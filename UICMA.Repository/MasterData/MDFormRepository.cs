using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.MD_Form;

namespace UICMA.Repository.ClaimRepository
{
  public class MDFormRepository:EntityBaseRepository<MDForm>, IMDFormRepository
    {

        private readonly UICMAContext context;
        public MDFormRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }

    }
}
