using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Form_Document;

namespace UICMA.Service.ClaimServices
{
   public interface IFormDocumentMapService
    {
        FormDocument AddandUpdateFormDocument(FormDocument formDocument);
        IEnumerable<FormDocument> GetFormDocumentAll();
        FormDocument GetFormDocumentbyID(int Id);

    }
}
