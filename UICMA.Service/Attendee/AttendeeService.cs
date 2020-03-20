using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities;
using UICMA.Repository;

namespace UICMA.Service.ClaimServices
{
  public class AttendeeService: IAttendeeService


    {
        private IAttendeeRepository _Attendee;

        public AttendeeService(IAttendeeRepository _Attendee)
        {
            this._Attendee = _Attendee;

        }


        //Add and Update Attendee

        public Attendee AddandUpdateAttendee(Attendee attendee)
        {
            Attendee attendees = new Attendee();


            if (attendee.Id == 0)
            {
                attendees = _Attendee.AddData(attendee);
            }
            else
            {
                attendees = _Attendee.UpdateData(attendee);
            }




            return attendees;

        }

        //Get Attendee All


        public IEnumerable<Attendee> GetclaimAttendeeAll()
        {

            return _Attendee.GetAll();

        }
        //Get Attendee By Attendee_Id

        public Attendee GetAttendeebyID(int Id)
        {

            return _Attendee.GetSingle(Id);

        }





    }
}
