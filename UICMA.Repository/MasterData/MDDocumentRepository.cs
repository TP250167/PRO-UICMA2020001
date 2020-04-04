using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.MD_Document;

namespace UICMA.Repository.ClaimRepository
{
   public class MDDocumentRepository:EntityBaseRepository<MDDocument>, IMDDocumentRepository
    {

        private readonly UICMAContext context;
        public MDDocumentRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }

    }
}
