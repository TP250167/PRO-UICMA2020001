using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;
using UICMA.Domain.Entities.Wages_After_Appeal;

namespace UICMA.Domain.Entities.Wages_After_AppealMap
{
   public class WagesAfterAppealMap
    {
        public WagesAfterAppealMap(EntityTypeBuilder<WagesAfterAppeal> builder)
        {
            builder.ToTable("WAGES_AFTER_APPEAL_TBL");
            builder.HasKey(s => s.Id).HasName("WAGES_AFTER_APPEAL_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.MailingDate ).HasColumnName("MAILING_DATE");
            builder.Property(s => s.PrintName).HasColumnName("PRINT_NAME");
            builder.Property(s => s.Title).HasColumnName("TITLE");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.CaseNumber).HasColumnName("CASE_NUMBER");
            builder.Property(s => s.DeadLineDate).HasColumnName("DEADLINE_DATE");
            builder.Property(s => s.PreparerName).HasColumnName("PREPARER_NAME");
            builder.Property(s => s.FormPath).HasColumnName("FORM_PATH");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.FaxNumber).HasColumnName("FAX_NUMBER");
            builder.Property(s => s.TelephoneNumber).HasColumnName("TELEPHONE_NUMBER");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");


            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.wagesAfterAppeal).HasForeignKey<WagesAfterAppeal>(t => t.ClaimId);
        }
    }
}
