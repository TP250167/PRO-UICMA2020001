using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.MD_Document;
using UICMA.Domain.Entities.MD_Form;

namespace UICMA.Domain.Entities.Associated_Documents
{
   public class AssociatedDocuments 
    {
        public Int64 DocumentId { get; set; }
        public Int64 FormId { get; set; }

        public MDDocument MDDocument { get; set; }
        public MDForm MDForms { get; set; }
    }
}
