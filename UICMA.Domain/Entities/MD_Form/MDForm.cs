using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Domain.Entities.MD_Form
{
   public class MDForm
    {
        public Int64 Id { get; set; }
        public string FormName { get; set; }
        public string FormCode { get; set; }
        public string FormStatus { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
