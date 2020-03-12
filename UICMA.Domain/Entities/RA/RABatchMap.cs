using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RABatchs;
using UICMA.Domain.Entities.RARecipientRules;

namespace UICMA.Domain.Entities.RABatchMap
{
  public class RABatchMap
    {
        public RABatchMap(EntityTypeBuilder<RABatchView> builder)
        {
            builder.ToTable("RA_BATCH_TBL");
            builder.HasKey(s => s.Id).HasName("RA_BATCH_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.BatchName).HasColumnName("BATCH_NAME");
            builder.Property(s => s.BatchDescription).HasColumnName("BATCH_DESCRIPTION");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.IsRecuring).HasColumnName("IS_RECURING").HasDefaultValue(false);
            builder.Property(s => s.Frequency).HasColumnName("FREQUENCY");
            builder.Property(s => s.Time).HasColumnName("TIME");
            builder.Property(s => s.Occurrance).HasColumnName("OCCURRANCE");
            builder.Property(s => s.Status).HasColumnName("STATUS");
            builder.Property(s => s.NextOccurrance).HasColumnName("NEXT_OCCURRANCE");
           
        }
    }
}
