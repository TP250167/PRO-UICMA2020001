using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.MD_Document;
using UICMA.Domain.Entities.MD_Form;

namespace UICMA.Domain.Entities.ClaimExceptions
{
   public class ClaimException :IBaseEntity
    {
        public Int64 Id { get; set; }
        public Int64 ClaimId { get; set; }
        public Int64 DocumentId { get; set; }
        public Int64 FormId { get; set; }
        public string ExceptionReason { get; set; }
        public DateTime? ExceptionDate { get; set; }
        public string CreatedBy  { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public MDDocument MDDocument { get; set; }
        public MDForm MDForm { get; set; }
    }
}
