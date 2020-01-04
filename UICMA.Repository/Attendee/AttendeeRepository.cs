using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities;

namespace UICMA.Repository
{
    public class AttendeeRepository : EntityBaseRepository<Attendee>, IAttendeeRepository
    {
        public AttendeeRepository(UICMAContext context) : base(context)
        {

        }
    }
}
