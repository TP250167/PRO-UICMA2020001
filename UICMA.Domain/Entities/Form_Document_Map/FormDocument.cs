using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.MD_Document;
using UICMA.Domain.Entities.MD_Form;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Form_Document
{
   public class FormDocument :IBaseEntity
    {
        public Int64 Id { get; set; }
        public Int64 DocumentId { get; set; }
        //public Int64 FormId { get; set; }
        public Int64 ClaimId { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string Channel { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string DocumentType { get; set; }
        public string DocumentName { get; set; }
        public string Stage { get; set; }
        public bool IsSharepointPushed { get; set; }

        public string SaveFileGUID { get; set; }
        

        public Claim claim { get; set; }
    }
}
