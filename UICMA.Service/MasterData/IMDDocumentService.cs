using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.MD_Document;

namespace UICMA.Service.MasterData
{
   public interface IMDDocumentService
    {

        MDDocument AddandUpdateMDDocument(MDDocument mdDocument);
        IEnumerable<MDDocument> GetMDDocumentAll();
        MDDocument GetMDDocumentbyID(int Id);
    }
}
