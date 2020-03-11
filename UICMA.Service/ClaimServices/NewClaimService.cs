using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
  public  class NewClaimService: INewClaimService
    {
        private INewClaimRepository _newClaim;

        public NewClaimService(INewClaimRepository _newClaim)
        {
            this._newClaim = _newClaim;

        }


        //Add and Update New Claim

        public Claim AddandUpdateNewClaim(Claim newClaim)
        {
            Claim claim = new Claim();


            if (newClaim.Id == 0)
            {
                claim = _newClaim.AddData(newClaim);
            }
            else
            {
                claim = _newClaim.UpdateData(newClaim);
            }




            return claim;

        }

        //Get New Claim All


        public IEnumerable<Claim> GetNewClaimAll()
        {

            return _newClaim.GetAll();

        }
        //Get New Claim By NewClaim_Id

        public Claim GetNewclaimbyID(int Id)
        {

            return _newClaim.GetSingle(Id);

        }
    }
}
