using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities;
using UICMA.Domain.Entities.ClaimExceptions;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
  public class ClaimExceptionService: IClaimExceptionService
    {
        private IClaimExceptionRepository _ClaimException;

        public ClaimExceptionService(IClaimExceptionRepository _ClaimException)
        {
            this._ClaimException = _ClaimException;

        }


        //Add and Update ClaimException

        public ClaimException AddandUpdateClaimException(ClaimException claimException)
        {
            ClaimException claimExceptions = new ClaimException();


            if (claimException.Id == 0)
            {
                claimExceptions = _ClaimException.AddData(claimException);
            }
            else
            {
                claimExceptions = _ClaimException.UpdateData(claimException);
            }




            return claimExceptions;

        }

        //Get ClaimException All


        public IEnumerable<ClaimException> GetClaimExceptionAll()
        {

            return _ClaimException.GetAll();

        }
        //Get ClaimException By ClaimException_Id

        public ClaimException GetClaimExceptionbyID(int Id)
        {

            return _ClaimException.GetSingle(Id);

        }

        public ViewClaimException GetClaimException(int Year)
        {

            ViewClaimException viewNewClaims = new ViewClaimException();


            viewNewClaims.NewClaimsException = _ClaimException.GetClaimsByYear(Year);
            viewNewClaims.Draw = 1;
            viewNewClaims.RecordsTotal = viewNewClaims.NewClaimsException.Count;

            return viewNewClaims;



        }

        //public Claim GetReqNumClaims(string RequestNumber)
        //{

        //    return _newClaim.GetReqNumClaims(RequestNumber);

        //}




    }
}
