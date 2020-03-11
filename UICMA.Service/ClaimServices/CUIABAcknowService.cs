using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.CUIAB_Acknowledgement;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
  public class CUIABAcknowService: ICUIABAcknowService
    {
        private ICUIABAcknowRepository _CUIABAcknow;

        public CUIABAcknowService(ICUIABAcknowRepository _CUIABAcknow)
        {
            this._CUIABAcknow = _CUIABAcknow;

        }


        //Add and Update CUIABAcknowledgement

        public CUIABAcknowledgement AddandUpdateCUIABAcknow(CUIABAcknowledgement cuiaAck)
        {
            CUIABAcknowledgement cuiaAcknow = new CUIABAcknowledgement();


            if (cuiaAck.Id == 0)
            {
                cuiaAcknow = _CUIABAcknow.AddData(cuiaAck);
            }
            else
            {
                cuiaAcknow = _CUIABAcknow.UpdateData(cuiaAck);
            }




            return cuiaAcknow;

        }

        //Get CUIABAcknowledgement All


        public IEnumerable<CUIABAcknowledgement> GetCUIABAcknowAll()
        {

            return _CUIABAcknow.GetAll();

        }
        //Get CUIABAcknowledgement By CUIABAcknowledgement_Id

        public CUIABAcknowledgement GetCUIABAcknowbyID(int Id)
        {

            return _CUIABAcknow.GetSingle(Id);

        }

    }
}
