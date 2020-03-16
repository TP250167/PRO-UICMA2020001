using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Domain.Entities.New_Claim
{
  public class ViewNewClaims
    {
        public int Draw { get; set; }
        public int RecordsTotal { get; set; }
        public int RecordsFiltered { get; set; }
     public List<Claim> NewClaims { get; set; }



    }
}
