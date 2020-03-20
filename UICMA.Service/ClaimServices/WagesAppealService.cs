using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Wages_Appeal;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
   public class WagesAppealService: IWagesAppealService
    {
        private IWagesAppealRepository _WagesAppeal;

        public WagesAppealService(IWagesAppealRepository _WagesAppeal)
        {
            this._WagesAppeal = _WagesAppeal;

        }


        //Add and Update claim Appeal

        public WagesAppeal AddandUpdateWagesAppeal(WagesAppeal wagesAppeal)
        {
            WagesAppeal wageappeal = new WagesAppeal();


            if (wagesAppeal.Id == 0)
            {
                wageappeal = _WagesAppeal.AddData(wagesAppeal);
            }
            else
            {
                wageappeal = _WagesAppeal.UpdateData(wagesAppeal);
            }




            return wageappeal;

        }

        //Get wagesAppeal All


        public IEnumerable<WagesAppeal> GetWagesAppealAll()
        {

            return _WagesAppeal.GetAll();

        }
        //Get wagesAppeall By WagesAppeal_Id

        public WagesAppeal GetWagesAppealbyID(int Id)
        {

            return _WagesAppeal.GetSingle(Id);

        }





    }
}
