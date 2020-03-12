using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RABatchs;
using UICMA.Domain.Entities.Templates;

namespace UICMA.Domain.Entities.RABatchTemplates
{
   public class RABatchTemplate :IBaseEntity
    {
        public Int64 Id { get; set; }
        public Int64 BatchId { get; set; }
        public Int64 TemplateId { get; set; }

        public RABatchView RAbatch { get; set; }
        public Template template { get; set; }
    }
}
