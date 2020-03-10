using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Determination;
using UICMA.Repository;

namespace UICMA.Service
{
  public  class ClaimDeterminationService:IClaimDeterminationService
    {

        private IClaimDeterminationRepository _claimDetermination;

        public ClaimDeterminationService(IClaimDeterminationRepository _claimDetermination)
        {
            this._claimDetermination = _claimDetermination;

        }


        //Add and Update claim Appeal

        public ClaimDetermination AddandUpdateClaimDetermination(ClaimDetermination ClaimDetermination)
        {
            ClaimDetermination determination = new ClaimDetermination();


            if (ClaimDetermination.Id == 0)
            {
                determination = _claimDetermination.AddData(ClaimDetermination);
            }
            else
            {
                determination = _claimDetermination.UpdateData(ClaimDetermination);
            }




            return determination;

        }

        //Get claim Appeal All


        public IEnumerable<ClaimDetermination> GetClaimDeterminationAll()
        {

            return _claimDetermination.GetAll();

        }
        //Get claim Appeal By ClaimDetermination_Id

        public ClaimDetermination GetClaimDeterminationbyID(int Id)
        {

            return _claimDetermination.GetSingle(Id);

        }
    }
}
