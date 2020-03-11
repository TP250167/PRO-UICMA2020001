using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Additional_Information;

namespace UICMA.Service.ClaimServices
{
   public interface IAdditionalInfoService
    {

        AdditionalInformation AddandUpdateAdditionalInfo(AdditionalInformation additionalInfor);
        IEnumerable<AdditionalInformation> GetAdditionalInfoAll();
        AdditionalInformation GetAdditionalInfobyID(int Id);
    }
}
