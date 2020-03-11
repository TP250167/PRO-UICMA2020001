using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.ALJ_Decision;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
  public  class ALJDecisionService: IALJDecisionService
    {
        private IALJDecisionRepository _aLJDecision;

        public ALJDecisionService(IALJDecisionRepository _aLJDecision)
        {
            this._aLJDecision = _aLJDecision;

        }


        //Add and Update ALJDecision

        public ALJDecision AddandUpdateALJDecision(ALJDecision aljDecision)
        {
            ALJDecision aLJDecisions = new ALJDecision();


            if (aljDecision.Id == 0)
            {
                aLJDecisions = _aLJDecision.AddData(aljDecision);
            }
            else
            {
                aLJDecisions = _aLJDecision.UpdateData(aljDecision);
            }




            return aLJDecisions;

        }

        //Get ALJDecision All


        public IEnumerable<ALJDecision> GetALJDecisionAll()
        {

            return _aLJDecision.GetAll();

        }
        //Get ALJDecision By ALJDecision_Id

        public ALJDecision GetALJDecisionbyID(int Id)
        {

            return _aLJDecision.GetSingle(Id);

        }
    }
}
