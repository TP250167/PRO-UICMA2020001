using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities;


namespace UICMA.Repository
{
    public class ScheduleRepository: EntityBaseRepository<Schedule>, IScheduleRepository
    {
        private readonly UICMAContext context;
        public ScheduleRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
