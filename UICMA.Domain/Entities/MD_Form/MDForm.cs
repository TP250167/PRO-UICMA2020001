using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Associated_Documents;
using UICMA.Domain.Entities.ClaimExceptions;
using UICMA.Domain.Entities.Form_Document;
using UICMA.Domain.Entities.MD_Document;

namespace UICMA.Domain.Entities.MD_Form
{
   public class MDForm:IBaseEntity
    {
        public Int64 Id { get; set; }
        public string FormName { get; set; }
        public string FormCode { get; set; }
        public string FormStatus { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public List<AssociatedDocuments> AssociatedDocuments { get; set; }
      //  public List<FormDocument> FormDocuments { get; set; }
        public List<ClaimException> ClaimExceptions { get; set; }
    }
}
