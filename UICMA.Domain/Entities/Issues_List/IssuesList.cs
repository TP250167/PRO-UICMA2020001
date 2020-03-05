using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Domain.Entities.Issues_List
{
    public class IssuesList : IBaseEntity
    {
        public Int64 Id { get; set; }
        public string IssueCode {get;set;}
        public string IssueDecription { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
