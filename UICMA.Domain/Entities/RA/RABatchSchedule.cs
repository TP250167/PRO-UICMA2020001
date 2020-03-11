using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RABatchs;

namespace UICMA.Domain.Entities.RABatchSchedules
{
  public class RABatchSchedule :IBaseEntity
    {
        public Int64 Id { get; set; }
        public Int64 BatchId { get; set; }
        public Int64 ScheduleId { get; set; }

        public RABatch RAbatch { get; set; }
        public Schedule schedule { get; set; }
    }
}
