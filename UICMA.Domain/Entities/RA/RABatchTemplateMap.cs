using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RABatchTemplates;

namespace UICMA.Domain.Entities.RABatchTemplateMap
{
    public class RABatchTemplateMap
    {
        public RABatchTemplateMap(EntityTypeBuilder<RABatchTemplate> builder)
        {
            builder.ToTable("RA_BATCH_TEMPLATE_MAP_TBL");
            builder.HasKey(s => s.Id).HasName("RA_BATCH_TEMPLATE_MAP_ID");
            builder.Property(s => s.BatchId).HasColumnName("BATCH_ID");
            builder.Property(s => s.TemplateId).HasColumnName("TEMPLATE_ID");

            builder.HasOne(t => t.RAbatch).WithMany(s => s.RAbatchTemplate).HasForeignKey(t => t.BatchId);
            builder.HasOne(t => t.template).WithMany(s => s.RAbatchTemplate).HasForeignKey(t => t.TemplateId);

        }
    }
}
