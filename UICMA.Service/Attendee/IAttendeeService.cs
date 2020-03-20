using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities;

namespace UICMA.Service.ClaimServices
{
   public interface IAttendeeService
    {

        Attendee AddandUpdateAttendee(Attendee attendee);
        IEnumerable<Attendee> GetclaimAttendeeAll();
        Attendee GetAttendeebyID(int Id);
    }
}
