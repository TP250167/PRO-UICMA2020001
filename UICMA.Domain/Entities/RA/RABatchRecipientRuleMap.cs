using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RABatchRecipientRules;
using UICMA.Domain.Entities.RABatchs;
using UICMA.Domain.Entities.RARecipientRules;

namespace UICMA.Domain.Entities.RABatchRecipientRuleMap
{
    public class RABatchRecipientRuleMap
    {
        public RABatchRecipientRuleMap(EntityTypeBuilder<RABatchRecipientRule> builder)
        {
            builder.ToTable("RA_BATCH_RECIP_RULE_MAP_TBL");
            builder.HasKey(s=>s.Id).HasName("RA_BATCH_RECIP_RULE_MAP_ID");
            builder.Property(s => s.BatchId).HasColumnName("BATCH_ID");
            builder.Property(s => s.RecipientRuleId).HasColumnName("RECIPIENT_RULE_ID");

            builder.HasOne(t => t.RAbatch).WithMany(s => s.RAbatchRecipientRule).HasForeignKey(t => t.BatchId);
            builder.HasOne(t => t.RArecipientRule).WithMany(s => s.RAbatchRecipientRule).HasForeignKey(t => t.RecipientRuleId);

        }
    }
}