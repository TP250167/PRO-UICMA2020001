using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
