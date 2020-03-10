using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Appeal;
using UICMA.Repository;

namespace UICMA.Service
{
   public class ClaimAppealService:IClaimAppealService
    {
        private IClaimAppealRepository _claimAppeal;

        public ClaimAppealService(IClaimAppealRepository _claimAppeal)
        {
            this._claimAppeal = _claimAppeal;

        }


        //Add and Update claim Appeal

        public ClaimAppeal AddandUpdateclaimAppeal(ClaimAppeal claimAppeal)
        {
            ClaimAppeal Appeal = new ClaimAppeal();


            if (claimAppeal.Id==0)
            {
                Appeal = _claimAppeal.AddData(claimAppeal);
            }
            else
            {
                Appeal = _claimAppeal.UpdateData(claimAppeal);
            }


            

            return Appeal;

        }

        //Get claim Appeal All


        public IEnumerable<ClaimAppeal> GetclaimAppealAll()
        {

            return _claimAppeal.GetAll();

        }
        //Get claim Appeal By claimAppeal_Id

        public ClaimAppeal GetclaimAppealbyID(int Id)
        {

            return _claimAppeal.GetSingle(Id);

        }





    }
}
