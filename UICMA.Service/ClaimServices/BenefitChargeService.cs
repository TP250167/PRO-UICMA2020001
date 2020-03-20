using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Benefit_Charge;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
  public  class BenefitChargeService: IBenefitChargeService
    {
        private IBenefitChargeRepository _BenefitCharge;

        public BenefitChargeService(IBenefitChargeRepository _BenefitCharge)
        {
            this._BenefitCharge = _BenefitCharge;

        }


        //Add and Update benefitCharge

        public BenefitCharge AddandUpdateBenefitCharge(BenefitCharge benefitCharge)
        {
            BenefitCharge benefitCharges = new BenefitCharge();


            if (benefitCharge.Id == 0)
            {
                benefitCharges = _BenefitCharge.AddData(benefitCharge);
            }
            else
            {
                benefitCharges = _BenefitCharge.UpdateData(benefitCharge);
            }




            return benefitCharges;

        }

        //Get benefitCharge All


        public IEnumerable<BenefitCharge> GetBenefitChargeAll()
        {

            return _BenefitCharge.GetAll();

        }
        //Get benefitCharge By benefitCharge_Id

        public BenefitCharge GetBenefitChargebyID(int Id)
        {

            return _BenefitCharge.GetSingle(Id);

        }





    }
}
