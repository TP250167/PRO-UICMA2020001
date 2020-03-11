using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RABatchs;
using UICMA.Domain.Entities.RARecipients;

namespace UICMA.Domain.Entities.RABatchRecipients
{
   public class RABatchRecipient :IBaseEntity
    {
        public Int64 Id { get; set; }
        public Int64 BatchId { get; set; }
        public Int64 RecipientId { get; set; }

        public RABatch RAbatch { get; set; }
        public RARecipient RArecipient { get; set; }
    }
}
