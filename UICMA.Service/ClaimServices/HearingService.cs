using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Hearings;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
   public class HearingService: IHearingService
    {
        private IHearingRepository _Hearing;

        public HearingService(IHearingRepository _Hearing)
        {
            this._Hearing = _Hearing;

        }


        //Add and Update hearing

        public Hearing AddandUpdateHearing(Hearing hearing)
        {
            Hearing hearingAppeal = new Hearing();


            if (hearing.Id == 0)
            {
                hearingAppeal = _Hearing.AddData(hearing);
            }
            else
            {
                hearingAppeal = _Hearing.UpdateData(hearing);
            }




            return hearingAppeal;

        }

        //Get claim hearing All


        public IEnumerable<Hearing> GetHearingAll()
        {

            return _Hearing.GetAll();

        }
        //Get hearing Appeal By Hearing_Id

        public Hearing GetHearingbyID(int Id)
        {

            return _Hearing.GetSingle(Id);

        }





    }
}
