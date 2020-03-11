using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RABatchSchedules;

namespace UICMA.Domain.Entities.RABatchScheduleMap
{
   public class RABatchScheduleMap
    {
        public RABatchScheduleMap(EntityTypeBuilder<RABatchSchedule> builder)
        {
            builder.ToTable("RA_BATCH_SCHEDULE_MAP_TBL");
            builder.HasKey(s => s.Id).HasName("RA_BATCH_SCHEDULE_MAP_ID");
            builder.Property(s => s.ScheduleId).HasColumnName("SCHEDULE_ID");
            builder.Property(s => s.BatchId).HasColumnName("BATCH_ID");

            builder.HasOne(t => t.schedule).WithMany(s => s.RAbatchSchedule).HasForeignKey(t => t.ScheduleId);
            builder.HasOne(t => t.RAbatch).WithMany(s => s.RAbatchSchedule).HasForeignKey(t => t.BatchId);
        }
    }
}
