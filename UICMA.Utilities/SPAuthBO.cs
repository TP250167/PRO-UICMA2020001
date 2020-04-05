using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Utilities
{
    public class SPAuthBO
    {

        public string SiteURL { get; set; }
        public string Domain { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        //public SharePointOnlineCredentials SPONCred { get; set; }

    }
}
