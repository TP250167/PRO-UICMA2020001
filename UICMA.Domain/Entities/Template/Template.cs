using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Domain.Entities.Templates
{
   public class Template :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string TemplateName { get; set; }
        public string TemplateCategory { get; set; }
        public string TemplateStatus { get; set; }
        public string TemplateBodyContent { get; set; }
        public string TemplateType { get; set; }
        public string TemplateDescription { get; set; }
        public string TemplateAttachmentContent { get; set; }
        public string LetterType { get; set; }
    }
}

