using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities;
using UICMA.Repository;

namespace UICMA.Service
{
    public class ScheduleService:IScheduleService
    {
        private IScheduleRepository scheduleRepository;
       

        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            this.scheduleRepository = scheduleRepository;
            
        }

        public IEnumerable<Schedule> GetAllSchedules()
        {
            return scheduleRepository.GetAll();
        }


    }
}
