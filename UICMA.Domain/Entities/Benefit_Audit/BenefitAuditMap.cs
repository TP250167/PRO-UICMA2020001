using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Benefit_Audit;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Benefit_AuditMap
{
   public class BenefitAuditMap
    {
        public BenefitAuditMap(EntityTypeBuilder<BenefitAudit> builder)
        {
            builder.ToTable("BENEFIT_AUDIT_TBL");
            builder.HasKey(s => s.Id).HasName("BENEFIT_AUDIT_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.Notes).HasColumnName("NOTES");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.MailDate).HasColumnName("MAIL_DATE");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");
            builder.Property(s => s.MailDate).HasColumnName("MAIL_DATE");

            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.benefitAudit).HasForeignKey<BenefitAudit>(t => t.ClaimId);
        }
    }
}
