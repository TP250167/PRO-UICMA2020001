using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Utilities
{
    public class DocRepositoryBO
    {
        public int ReqID { get; set; }
        public int DocID { get; set; }
        public string DocNumber { get; set; }   
        public string DocName { get; set; }
        public string DocType { get; set; }
        public string DocumentLibraryName { get; set; }
        public int Stage { get; set; }
        public string Site { get; set; }
        public string Category { get; set; } // Report,Inbound,Outbound
        public string FilePath { get; set; }         
        public string Title { get; set; }          
        public string DocVersion { get; set; }    
        public string CreatedOn { get; set; }
        public string ModifiedOn { get; set; }
        public Uri SPFilePathUri { get;  set; }
    }
}
