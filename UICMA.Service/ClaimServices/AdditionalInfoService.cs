using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Additional_Information;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
   public class AdditionalInfoService: IAdditionalInfoService
    {
        private IAdditionalInfoRepository _additionalInfo;

        public AdditionalInfoService(IAdditionalInfoRepository _additionalInfo)
        {
            this._additionalInfo = _additionalInfo;

        }


        //Add and Update AdditionalInfo

        public AdditionalInformation AddandUpdateAdditionalInfo(AdditionalInformation additionalInfor)
        {
            AdditionalInformation additional = new AdditionalInformation();


            if (additionalInfor.Id == 0)
            {
                additional = _additionalInfo.AddData(additionalInfor);
            }
            else
            {
                additional = _additionalInfo.UpdateData(additionalInfor);
            }




            return additional;

        }

        //Get AdditionalInfo All


        public IEnumerable<AdditionalInformation> GetAdditionalInfoAll()
        {

            return _additionalInfo.GetAll();

        }
        //Get AdditionalInfo By Id

        public AdditionalInformation GetAdditionalInfobyID(int Id)
        {

            return _additionalInfo.GetSingle(Id);

        }


    }
}
