using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Interview;
using UICMA.Repository;

namespace UICMA.Service
{
   public class ClaimInterviewService:IClaimInterviewService
    {

        private IClaimInterviewRepository _claimInterview;
        public ClaimInterviewService(IClaimInterviewRepository _claimInterview)
        {
            this._claimInterview = _claimInterview;

        }


        //Add and Update claim Appeal

        public ClaimInterview AddandUpdateClaimInterview(ClaimInterview claimInterview)
        {
            ClaimInterview interview = new ClaimInterview();


            if (claimInterview.Id == 0)
            {
                interview = _claimInterview.AddData(claimInterview);
            }
            else
            {
                interview = _claimInterview.UpdateData(claimInterview);
            }




            return interview;

        }

        //Get claim Appeal All
        public IEnumerable<ClaimInterview> GetClaimInterviewAll()
        {

            return _claimInterview.GetAll();

        }
        //Get claim Appeal By ClaimInterview_Id

        public ClaimInterview GetClaimInterviewbyID(int Id)
        {

            return _claimInterview.GetSingle(Id);

        }


    }
}
