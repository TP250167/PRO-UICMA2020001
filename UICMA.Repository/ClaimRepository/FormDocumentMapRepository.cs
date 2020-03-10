using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Form_Document;

namespace UICMA.Repository.ClaimRepository
{
       public class FormDocumentMapRepository : EntityBaseRepository<FormDocument>, IFormDocumentMapRepository
    {
        private readonly UICMAContext context;
        public FormDocumentMapRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
