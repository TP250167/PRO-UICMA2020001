using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RAAssociatedDocuments;
using UICMA.Domain.Entities.RABatchSchedules;

namespace UICMA.Domain.Entities.RASchedules
{
   public class RASchedule :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string CreatedBy { get; set; }
        public int? TotalRecipient { get; set; }
        public int? SucessfulDelivery { get; set; }
        public int? FailedDelivery { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public string Status { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public ICollection<RAAssociatedDocument> RAassociatedDocument { get; set; }
        public ICollection<RABatchSchedule> RAbatchSchedule { get; set; }
    }
}

//BATCH_ID INT(FK)



