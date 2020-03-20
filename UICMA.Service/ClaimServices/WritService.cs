using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Writs;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
   public class WritService: IWritService
    {
        private IWritRepository _Writ;

        public WritService(IWritRepository _Writ)
        {
            this._Writ = _Writ;

        }


        //Add and Update claim Appeal

        public Writ AddandUpdateWrit(Writ writ)
        {
            Writ writAppeal = new Writ();


            if (writ.Id == 0)
            {
                writAppeal = _Writ.AddData(writ);
            }
            else
            {
                writAppeal = _Writ.UpdateData(writ);
            }




            return writAppeal;

        }

        //Get claim Appeal All


        public IEnumerable<Writ> GetWritAll()
        {

            return _Writ.GetAll();

        }
        //Get claim Appeal By Writ_Id

        public Writ GetWritbyID(int Id)
        {

            return _Writ.GetSingle(Id);

        }





    }
}
