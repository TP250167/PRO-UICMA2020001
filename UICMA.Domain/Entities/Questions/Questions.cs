using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Interview;

namespace UICMA.Domain.Entities.Questions
{
   public class Question :IBaseEntity
    {
        public Int64 Id { get; set; }
        public Int64 ClaimId { get; set; }
        public string CreatedBy{ get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Int64 FormId { get; set; }
        public string LAUSDQuestions { get; set; }
        public string LAUSDResponses { get; set; }

        public ClaimInterview claimInterview { get; set; }

    }
}
