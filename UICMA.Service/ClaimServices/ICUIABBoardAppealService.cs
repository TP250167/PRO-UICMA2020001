using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.CUIAB_Board_Appeal;

namespace UICMA.Service.ClaimServices
{
   public interface ICUIABBoardAppealService
    {
        CUIABBoardAppeal AddandUpdateCUIABBoardAppeal(CUIABBoardAppeal CUIABBoard);
        IEnumerable<CUIABBoardAppeal> GetCUIABBoardAppealAll();
        CUIABBoardAppeal GetCUIABBoardAppealbyID(int Id);

    }
}
