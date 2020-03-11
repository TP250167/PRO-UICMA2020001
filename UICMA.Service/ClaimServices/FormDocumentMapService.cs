using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Form_Document;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
  public  class FormDocumentMapService: IFormDocumentMapService
    {
        private IFormDocumentMapRepository _FormDocumentMap;

        public FormDocumentMapService(IFormDocumentMapRepository _FormDocumentMap)
        {
            this._FormDocumentMap = _FormDocumentMap;

        }


        //Add and Update FormDocument

        public FormDocument AddandUpdateFormDocument(FormDocument formDocument)
        {
            FormDocument formDoc = new FormDocument();


            if (formDocument.Id == 0)
            {
                formDoc = _FormDocumentMap.AddData(formDocument);
            }
            else
            {
                formDoc = _FormDocumentMap.UpdateData(formDocument);
            }




            return formDoc;

        }

        //Get FormDocument All


        public IEnumerable<FormDocument> GetFormDocumentAll()
        {

            return _FormDocumentMap.GetAll();

        }
        //Get FormDocument By FormDocument_Id

        public FormDocument GetFormDocumentbyID(int Id)
        {

            return _FormDocumentMap.GetSingle(Id);

        }
    }
}
