using System;
using System.Collections.Generic;
using System.Text;

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
    }
}

//BATCH_ID INT(FK)



