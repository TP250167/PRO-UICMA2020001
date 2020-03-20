using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Determination_Appeal;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
   public class DeterminationAppealService: IDeterminationAppealService
    {
        private IDeterminationAppealRepository _IDeterminationAppeal;

        public DeterminationAppealService(IDeterminationAppealRepository _IDeterminationAppeal)
        {
            this._IDeterminationAppeal = _IDeterminationAppeal;

        }


        //Add and Update DeterAppeal

        public DeterminationAppeal AddandUpdateDeterminationAppeal(DeterminationAppeal Determination)
        {
            DeterminationAppeal DeterAppeal = new DeterminationAppeal();


            if (Determination.Id == 0)
            {
                DeterAppeal = _IDeterminationAppeal.AddData(Determination);
            }
            else
            {
                DeterAppeal = _IDeterminationAppeal.UpdateData(Determination);
            }
                       
            return DeterAppeal;

        }

        //Get DeterAppeal All


        public IEnumerable<DeterminationAppeal> GetDeterminationAppealAll()
        {

            return _IDeterminationAppeal.GetAll();

        }
        //Get DeterAppeal By DeterAppeal_Id

        public DeterminationAppeal GetDeterminationAppealbyID(int Id)
        {

            return _IDeterminationAppeal.GetSingle(Id);

        }





    }
}
