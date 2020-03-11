using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Wages_After_Appeal;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
   public class WagesAfterAppealService: IWagesAfterAppealService
    {
        private IWagesAfterAppealRepository _wagesAfterAppeal;

        public WagesAfterAppealService(IWagesAfterAppealRepository _wagesAfterAppeal)
        {
            this._wagesAfterAppeal = _wagesAfterAppeal;

        }


        //Add and Update WagesAfter Appeal

        public WagesAfterAppeal AddandUpdateWagesAfterAppeal(WagesAfterAppeal claimAppeal)
        {
            WagesAfterAppeal Appeal = new WagesAfterAppeal();


            if (claimAppeal.Id == 0)
            {
                Appeal = _wagesAfterAppeal.AddData(claimAppeal);
            }
            else
            {
                Appeal = _wagesAfterAppeal.UpdateData(claimAppeal);
            }




            return Appeal;

        }

        //Get WagesAfterAppeal All


        public IEnumerable<WagesAfterAppeal> GetWagesAfterAppealAll()
        {

            return _wagesAfterAppeal.GetAll();

        }
        //Get WagesAfterAppeal By WagesAfterAppeal_Id

        public WagesAfterAppeal GetWagesAfterAppealbyID(int Id)
        {

            return _wagesAfterAppeal.GetSingle(Id);

        }
    }
}
