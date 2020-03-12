using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Associated_Documents;
using UICMA.Domain.Entities.ClaimExceptions;
using UICMA.Domain.Entities.Form_Document;
using UICMA.Domain.Entities.MD_Form;

namespace UICMA.Domain.Entities.MD_Document
{
   public class MDDocument
    {
        public Int64 Id { get; set; }
        public string DocumentName { get; set; }
        public string DocumentStatus { get; set; }
        public string DocumentDescription { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsMandatory { get; set; }

        public List<AssociatedDocuments> AssociatedDocuments { get; set; }
        public List<FormDocument> FormDocuments { get; set; }
        public List<ClaimException> ClaimExceptions { get; set; }
    }
}
