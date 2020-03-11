using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RABatchRecipients;

namespace UICMA.Domain.Entities.RABatchRecipientMap
{
   public class RABatchRecipientMap
    {
        public RABatchRecipientMap(EntityTypeBuilder<RABatchRecipient> builder)
        {
            builder.ToTable("RA_BATCH_RECIPIENT_MAP_TBL");
            builder.HasKey(s => s.Id).HasName("RA_BATCH_RECIPIENT_MAP_ID");
            builder.Property(s => s.BatchId).HasColumnName("BATCH_ID");
            builder.Property(s => s.RecipientId).HasColumnName("RECIPIENT_ID");

            builder.HasOne(t => t.RAbatch).WithMany(s => s.RAbatchRecipient).HasForeignKey(t => t.BatchId);
            builder.HasOne(t => t.RArecipient).WithMany(s => s.RAbatchRecipient).HasForeignKey(t => t.RecipientId);

        }
    }
}
