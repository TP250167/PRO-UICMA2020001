using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RASchedules;

namespace UICMA.Domain.Entities.RAScheduleMap
{
   public class RAScheduleMap
    {
       public RAScheduleMap(EntityTypeBuilder<RASchedule> builder)
        {
            builder.ToTable("RA_SCHEDULE_TBL");
            builder.HasKey(s => s.Id).HasName("RA_SCHEDULE_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.ScheduleDate).HasColumnName("SCHEDULE_DATE");
            builder.Property(s => s.TotalRecipient).HasColumnName("TOTAL_RECIPIENT");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.SucessfulDelivery).HasColumnName("SUCESSFUL_DELIVERY");
            builder.Property(s => s.FailedDelivery).HasColumnName("FAILED_DELIVERY");
            builder.Property(s => s.Status).HasColumnName("STATUS");
        }
    }
}
