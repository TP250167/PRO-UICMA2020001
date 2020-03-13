using Microsoft.EntityFrameworkCore.ChangeTracking;
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
        //public RASchedule AddSheduleData(RASchedule entity)
        //{
        //    EntityEntry dbEntityEntry = context.Entry(entity);
        //    context.Set<RASchedule>().Add(entity);
        //    entity.Id.AsNoTracking();
        //    context.SaveChanges();
        //    return entity;
        //}

    }
}
