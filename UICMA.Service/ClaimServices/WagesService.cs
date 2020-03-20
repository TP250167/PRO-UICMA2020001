using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.NoticeOfWages;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
   public class WagesService: IWagesService
    {
        private IWagesRepository _Wages;

        public WagesService(IWagesRepository _Wages)
        {
            this._Wages = _Wages;

        }


        //Add and Update wages

        public Wages AddandUpdateWages(Wages wages)
        {
            Wages wagesAppeal = new Wages();


            if (wages.Id == 0)
            {
                wagesAppeal = _Wages.AddData(wages);
            }
            else
            {
                wagesAppeal = _Wages.UpdateData(wages);
            }




            return wagesAppeal;

        }

        //Get wages All


        public IEnumerable<Wages> GetWagesAll()
        {

            return _Wages.GetAll();

        }
        //Get cwages By Wages_Id

        public Wages GetWagesbyID(int Id)
        {

            return _Wages.GetSingle(Id);

        }





    }
}
