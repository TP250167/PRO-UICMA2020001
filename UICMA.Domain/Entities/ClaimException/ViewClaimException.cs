using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.ClaimExceptions;

namespace UICMA.Domain.Entities
{
  public class ViewClaimException
    {
        public int Draw { get; set; }
        public int RecordsTotal { get; set; }
        public int RecordsFiltered { get; set; }
        public List<ClaimException> NewClaimsException { get; set; }
    }
}
