using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RARecipientRules;

namespace UICMA.Domain.Entities.RARecipientRuleMap
{
   public class RARecipientRuleMap
    {
        public RARecipientRuleMap(EntityTypeBuilder<RARecipientRule> builder)
        {
            builder.ToTable("RA_RECIPIENT_RULE_TBL");
            builder.HasKey(s => s.Id).HasName("RA_RECIPIENT_RULE_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.RecipientRuleName).HasColumnName("RECIPIENT_RULE_NAME");
            builder.Property(s => s.RecipientRuleStatus).HasColumnName("RECIPIENT_RULE_STATUS");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.RecipientRuleType).HasColumnName("RECIPIENT_RULE_TYPE");
            builder.Property(s => s.IsAnnual).HasColumnName("IS_ANNUAL").HasDefaultValue(false);
        }
    }
}
