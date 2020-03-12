using System;
using System.Collections.Generic;
using System.Text;

using UICMA.Domain.Entities.RASchedules;

namespace UICMA.Repository.RARepository
{
   public class RAScheduleRepository :EntityBaseRepository<RASchedule>, IRAScheduleRepository
    {

        private readonly UICMAContext context;
        public RAScheduleRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }

    }
}
