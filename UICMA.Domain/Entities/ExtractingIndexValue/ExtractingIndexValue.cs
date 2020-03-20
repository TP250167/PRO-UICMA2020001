using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Domain.Entities.ExtractingIndexValues
{
   public class ExtractingIndexValue :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string FormNumber { get; set; }
        public string FieldName { get; set; }
        public string PositionTopLeft { get; set; }
        public string PositionBottomRight { get; set; }
        public string Status { get; set; }
    }
}
