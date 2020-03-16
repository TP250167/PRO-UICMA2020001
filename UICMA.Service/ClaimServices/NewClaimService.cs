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



        public IEnumerable<Claim> GetActiveClaims(int Year)
        {

            return _newClaim.GetActiveClaims(Year);

        }

        public IEnumerable<Claim> GetExceptionClaims(int Year)
        {

            return _newClaim.GetExceptionClaims(Year);

        }


        public ViewNewClaims GetActivesClaims(int Year,string Status)
        {
            
            ViewNewClaims viewNewClaims = new ViewNewClaims();

            
            viewNewClaims.NewClaims= _newClaim.GetClaimsByYear(Year, Status);
            viewNewClaims.Draw = 1;
            viewNewClaims.RecordsTotal = viewNewClaims.NewClaims.Count;
           
            return viewNewClaims;



        }

        public Claim GetReqNumClaims(string RequestNumber)
        {

            return _newClaim.GetReqNumClaims(RequestNumber);

        }

        

    }
}
