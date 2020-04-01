using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UICMA.Domain.Entities.ClaimExceptions;

namespace UICMA.Repository.ClaimRepository
{
    public class ClaimExceptionRepository : EntityBaseRepository<ClaimException>, IClaimExceptionRepository
    {
        private readonly UICMAContext context;
        public ClaimExceptionRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }


        public List<ClaimException> GetClaimsByYear(int Year)
        {
            var ActiveClaims = context.ClaimExceptions.Where(s => s.BenefitYearBeginning == Year).ToList();

            return ActiveClaims;
        }

        //public ClaimException GetReqNumClaims(string RequestNumber)
        //{
        //    var ActiveClaims = context.ClaimExceptions.Where(s => s.RequestNumber == RequestNumber).FirstOrDefault();

        //    return ActiveClaims;
        //}




    }
}
