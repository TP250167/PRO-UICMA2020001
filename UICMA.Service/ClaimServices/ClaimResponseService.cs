using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Response;
using UICMA.Repository;

namespace UICMA.Service
{
   public class ClaimResponseService:IClaimResponseService
    {

        // private IClaimResponse _claimResponse;
        private IClaimResponseRepository _claimResponse;


        public ClaimResponseService(IClaimResponseRepository _claimResponse)
        {
            this._claimResponse = _claimResponse;

        }


        //Add and Update claim Appeal

        public ClaimResponse AddandUpdateClaimResponse(ClaimResponse claimResponse)
        {
            ClaimResponse response = new ClaimResponse();


            if (claimResponse.Id == 0)
            {
                response = _claimResponse.AddData(claimResponse);
            }
            else
            {
                response = _claimResponse.UpdateData(claimResponse);
            }




            return response;

        }

        //Get claim Appeal All


        public IEnumerable<ClaimResponse> GetClaimResponseAll()
        {

            return _claimResponse.GetAll();

        }
        //Get claim Appeal By ClaimResponse_Id

        public ClaimResponse GetClaimResponsebyID(int Id)
        {

            return _claimResponse.GetSingle(Id);

        }

    }
}
