using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RABatchSchedules;

namespace UICMA.Repository.RARepository
{
   public class RABatchScheduleRepository : EntityBaseRepository<RABatchSchedule>, IRABatchScheduleRepository
    {
        private readonly UICMAContext context;
        public RABatchScheduleRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }



    }
}
