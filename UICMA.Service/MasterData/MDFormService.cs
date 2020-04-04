using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.MD_Form;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.MasterData
{
   public class MDFormService: IMDFormService
    {
       
        private IMDFormRepository _MDForm;

        public MDFormService(IMDFormRepository _MDForm)
        {
            this._MDForm = _MDForm;

        }


        //Add and Update MDForm

        public MDForm AddandUpdateMDForm(MDForm form)
        {
            MDForm mdForm = new MDForm();


            if (form.Id == 0)
            {
                mdForm = _MDForm.AddData(form);
            }
            else
            {
                mdForm = _MDForm.UpdateData(form);
            }
            return mdForm;

        }

        //Get MDForm All


        public IEnumerable<MDForm> GetMDFormAll()
        {

            return _MDForm.GetAll();

        }
        //GetMDForm by Id

        public MDForm GetMDFormbyID(int Id)
        {

            return _MDForm.GetSingle(Id);

        }





    }
}   
