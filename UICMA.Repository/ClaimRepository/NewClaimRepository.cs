using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Repository.ClaimRepository
{
    

    public class NewClaimRepository : EntityBaseRepository<Claim>, INewClaimRepository
    {
        private readonly UICMAContext context;
        public NewClaimRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }


        public IEnumerable<Claim> GetActiveClaims(int Year)
        {
            var ActiveClaims = context.Claims.Where(s => s.CurrentStage == "Active" && s.BenefitYearBeginning == Year).ToList();

            return ActiveClaims;
        }

        public IEnumerable<Claim> GetExceptionClaims(int Year)
        {
            var ActiveClaims = context.Claims.Where(s => s.CurrentStage == "Exception" && s.BenefitYearBeginning == Year).ToList();

            return ActiveClaims;
        }


        public List<Claim> GetClaimsByYear(int Year,string Status)
        {
            var ActiveClaims = context.Claims.Where(s => s.CurrentStage == Status && s.BenefitYearBeginning == Year).ToList();

            return ActiveClaims;
        }

        public Claim GetReqNumClaims(string RequestNumber)
        {
            var ActiveClaims = context.Claims.Where(s => s.CurrentStage == "Active" && s.RequestNumber == RequestNumber).FirstOrDefault();

            return ActiveClaims;
        }


    }
}
