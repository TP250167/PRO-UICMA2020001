using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.CUIAB_Board_Appeal;

namespace UICMA.Repository.ClaimRepository
{
   public class CUIABBoardAppealRepository : EntityBaseRepository<CUIABBoardAppeal>, ICUIABBoardAppealRepository
    {
        private readonly UICMAContext context;
        public CUIABBoardAppealRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }

}
