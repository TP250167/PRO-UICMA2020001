using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Domain.Entities { 
    public class User : IBaseEntity
    {
        public User()
        {
            SchedulesCreated = new List<Schedule>();
            SchedulesAttended = new List<Attendee>();
        }
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Profession { get; set; }
        public ICollection<Schedule> SchedulesCreated { get; set; }
        public ICollection<Attendee> SchedulesAttended { get; set; }
    }
}
