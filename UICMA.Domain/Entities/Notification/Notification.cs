using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Domain.Entities.Notifications
{
   public class Notification :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string NotifyAttachment { get; set; }
        public string NotifyTo { get; set; }
        public string NotifyCC { get; set; }
        public string NotifyBCC { get; set; }
        public string NotifyFrom { get; set; }
        public string NotifySubject { get; set; }
        public string NotifyBody { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string NotifyStatus { get; set; }
        public string RequestType { get; set; }
    }
}
