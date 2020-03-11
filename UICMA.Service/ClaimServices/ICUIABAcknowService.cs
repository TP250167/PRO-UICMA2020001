using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.CUIAB_Acknowledgement;

namespace UICMA.Service.ClaimServices
{
   public interface ICUIABAcknowService
    {
        CUIABAcknowledgement AddandUpdateCUIABAcknow(CUIABAcknowledgement cuiaAck);
        IEnumerable<CUIABAcknowledgement> GetCUIABAcknowAll();
        CUIABAcknowledgement GetCUIABAcknowbyID(int Id);

    }
}
