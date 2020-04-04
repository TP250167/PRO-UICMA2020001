using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.MD_Document;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.MasterData
{
   public class MDDocumentService: IMDDocumentService
    {
       

        private IMDDocumentRepository _MDDocument;

        public MDDocumentService(IMDDocumentRepository _MDDocument)
        {
            this._MDDocument = _MDDocument;

        }


        //Add and Update MDDocument

        public MDDocument AddandUpdateMDDocument(MDDocument document)
        {
            MDDocument documentAppeal = new MDDocument();


            if (document.Id == 0)
            {
                documentAppeal = _MDDocument.AddData(document);
            }
            else
            {
                documentAppeal = _MDDocument.UpdateData(document);
            }




            return documentAppeal;

        }

        //Get MDDocument All


        public IEnumerable<MDDocument> GetMDDocumentAll()
        {

            return _MDDocument.GetAll();

        }
        //Get MDDocument By MDDocument_Id

        public MDDocument GetMDDocumentbyID(int Id)
        {

            return _MDDocument.GetSingle(Id);

        }





    }
}

  