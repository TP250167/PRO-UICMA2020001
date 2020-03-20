using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Benefit_Audit;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
   public class BenefitAuditService: IBenefitAuditService
    {
        private IBenefitAuditRepository _BenefitAudit;

        public BenefitAuditService(IBenefitAuditRepository _BenefitAudit)
        {
            this._BenefitAudit = _BenefitAudit;

        }


        //Add and Update BenefitAudit

        public BenefitAudit AddandUpdateBenefitAudit(BenefitAudit benefitAudit)
        {
            BenefitAudit benefitAudits = new BenefitAudit();


            if (benefitAudit.Id == 0)
            {
                benefitAudits = _BenefitAudit.AddData(benefitAudit);
            }
            else
            {
                benefitAudits = _BenefitAudit.UpdateData(benefitAudit);
            }




            return benefitAudits;

        }

        //Get BenefitAudit All


        public IEnumerable<BenefitAudit> GetBenefitAuditAll()
        {

            return _BenefitAudit.GetAll();

        }
        //Get BenefitAudit By BenefitAudit_Id

        public BenefitAudit GetBenefitAuditbyID(int Id)
        {

            return _BenefitAudit.GetSingle(Id);

        }





    }
}
