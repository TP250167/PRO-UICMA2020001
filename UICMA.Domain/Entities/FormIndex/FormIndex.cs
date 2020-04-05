using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Domain.Entities.FormIndex
{
 public class FormIndex: IBaseEntity
    {
        public Int64 Id { get; set; }
        public string Formcode { get; set; }
        public string FieldName { get; set; }
        public string PositionTopLeft { get; set; }
        public string PositionBottomRight { get; set; }
        public string Status { get; set; }
        public int LineNumber { get; set; }

    }
}
