using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.CUIAB_Board_Appeal;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
  public class CUIABBoardAppealService: ICUIABBoardAppealService
    {
        private ICUIABBoardAppealRepository _CUIABBoardAppeal;

        public CUIABBoardAppealService(ICUIABBoardAppealRepository _CUIABBoardAppeal)
        {
            this._CUIABBoardAppeal = _CUIABBoardAppeal;

        }


        //Add and Update CUIABBoardAppeal

        public CUIABBoardAppeal AddandUpdateCUIABBoardAppeal(CUIABBoardAppeal CUIABBoard)
        {
            CUIABBoardAppeal CUIABAppeal = new CUIABBoardAppeal();


            if (CUIABBoard.Id == 0)
            {
                CUIABAppeal = _CUIABBoardAppeal.AddData(CUIABBoard);
            }
            else
            {
                CUIABAppeal = _CUIABBoardAppeal.UpdateData(CUIABBoard);
            }
                       

            return CUIABAppeal;

        }

        //Get CUIABBoardAppeal All


        public IEnumerable<CUIABBoardAppeal> GetCUIABBoardAppealAll()
        {

            return _CUIABBoardAppeal.GetAll();

        }
        //Get CUIABBoardAppeal By CUIABBoardAppeal_Id

        public CUIABBoardAppeal GetCUIABBoardAppealbyID(int Id)
        {

            return _CUIABBoardAppeal.GetSingle(Id);

        }





    }
}
