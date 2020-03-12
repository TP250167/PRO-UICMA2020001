using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RARecipients;
using UICMA.Domain.Entities.RASchedules;

namespace UICMA.Domain.Entities.RAAssociatedDocuments
{
   public class RAAssociatedDocument :IBaseEntity
    {
        public Int64 Id { get; set; }
        public string Type { get; set; }
        public string DocumentationPath { get; set; }
        public Int64 RAScheduleId { get; set; }
        public Int64 RecipientId { get; set; }

        public RASchedule RAschedule { get; set; }
        public RARecipient RArecipient { get; set; }
    }
}
