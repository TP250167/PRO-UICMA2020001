using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Questions;

namespace UICMA.Repository.ClaimRepository
{
   public class QuestionsRepository : EntityBaseRepository<Question>, IQuestionsRepository
    {
        private readonly UICMAContext context;
        public QuestionsRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
