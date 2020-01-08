using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Domain.Entities
{
    public class Attendee:IBaseEntity
    {

        public Int64 Id { get; set; }
        public Int64 UserId { get; set; }    
        public Int64 ScheduleId { get; set; }
        public User User { get; set; }
        public Schedule Schedule { get; set; }
    }
}
