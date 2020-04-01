using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Hearings;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.HearingMap
{
   public class HearingMap
    {
        public HearingMap(EntityTypeBuilder<Hearing> builder)
        {
            builder.ToTable("NOTICE_OF_HEARING_TBL");
            builder.HasKey(s => s.Id).HasName("NOTICE_OF_HEARING_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.AdministrativeLawJudge).HasColumnName("ADMINISTRATIVE_LAW_JUDGE");
            builder.Property(s => s.Notes).HasColumnName("NOTES");
            builder.Property(s => s.AppellantName).HasColumnName("APPELLANT_NAME");
            builder.Property(s => s.AppellantType).HasColumnName("APPELLANT_TYPE").HasDefaultValue(false);
            builder.Property(s => s.HearingTime).HasColumnName("HEARING_TIME");
            builder.Property(s => s.HearingPlace).HasColumnName("HEARING_PLACE");
            builder.Property(s => s.HearingDate).HasColumnName("HEARING_DATE");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.CaseNumber).HasColumnName("CASE_NUMBER");
            builder.Property(s => s.EDDOffice).HasColumnName("EDD_OFFICE");
            builder.Property(s => s.IssuesList).HasColumnName("ISSUES_LIST");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");

            builder.Property(s => s.EmployerInfo).HasColumnName("EMPLOYER_INFO");
            builder.Property(s => s.IssueCode).HasColumnName("ISSUE_CODE");
            builder.Property(s => s.IssueContext).HasColumnName("ISSUE_CONTEXT");
            builder.Property(s => s.ClaimantAppellant).HasColumnName("CLAIMANT_APPELLANT");
            builder.Property(s => s.LAUSDAppelant).HasColumnName("LAUSD_APPELLANT");

            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");
            builder.Property(s => s.MailDate).HasColumnName("MAIL_DATE");

            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.hearing).HasForeignKey<Hearing>(t => t.ClaimId);
        }
    }
}
