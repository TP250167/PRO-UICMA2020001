using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Determination;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Claim_DeterminationMap
{
   public class ClaimDeterminationMap
    {
        public ClaimDeterminationMap(EntityTypeBuilder<ClaimDetermination> builder)
        {
            builder.ToTable("CLAIM_DETERMINATION_TBL");
            builder.HasKey(s => s.Id).HasName("CLAIM_DETERMINATION_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.Decision).HasColumnName("DECISION");
            builder.Property(s => s.MailedDate).HasColumnName("MAILED_DATE");
            builder.Property(s => s.BenefitYearBegan).HasColumnName("BENEFIT_YEAR_BEGAN");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.FieldOffice).HasColumnName("FIELD_OFFICE");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.FormPath).HasColumnName("FORM_PATH");
            builder.Property(S => S.ClaimId).HasColumnName("CLAIM_ID");

            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.claimDetermination).HasForeignKey<ClaimDetermination>(t => t.ClaimId);
        }
    }
}
