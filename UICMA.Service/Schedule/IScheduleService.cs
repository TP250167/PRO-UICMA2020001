using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities;

namespace UICMA.Service
{
    public interface IScheduleService
    {
        IEnumerable<Schedule> GetAllSchedules();
    }
}
