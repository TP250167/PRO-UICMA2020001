using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Interview;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Claim_InterviewMap
{
   public class ClaimInterviewMap
    {
        public ClaimInterviewMap(EntityTypeBuilder<ClaimInterview> builder)
        {
            builder.ToTable("CLAIM_INTERVIEW_TBL");
            builder.HasKey(s => s.Id).HasName("CLAIM_INTERVIEW_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.City).HasColumnName("CITY");
            builder.Property(s => s.State).HasColumnName("STATE");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.Zipcode).HasColumnName("ZIPCODE");
            builder.Property(s => s.Address).HasColumnName("ADDRESS");
            builder.Property(s => s.LAUSDFaxDate).HasColumnName("LAUSD_FAX_DATE");
            builder.Property(s => s.BYBClaimDate).HasColumnName("BYB_CLAIM_DATE");
            builder.Property(s => s.EffectiveDate).HasColumnName("EFFECTIVE_DATE");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.Status).HasColumnName("STATUS");
            builder.Property(s => s.Date).HasColumnName("DATE");
            builder.Property(s => s.Time).HasColumnName("TIME");
            builder.Property(s => s.DETInterviewer).HasColumnName("DET_INTERVIEWER");
            builder.Property(s => s.InterviewerPhoneNumber).HasColumnName("INTERVIEWER_PHONE_NUMBER");
            builder.Property(s => s.RepresentativeName).HasColumnName("REPRESENTATIVE_NAME");
            builder.Property(s => s.PhoneNumber).HasColumnName("PHONE_NUMBER");
            builder.Property(s => s.Signature).HasColumnName("SIGNATURE");
            builder.Property(s => s.Title).HasColumnName("TITLE");
            builder.Property(s => s.PrintName).HasColumnName("PRINT_NAME");
            builder.Property(s => s.RepresentativeDate).HasColumnName("REPRESENTATIVE_DATE");
            builder.Property(s => s.IssuesList).HasColumnName("ISSUES_LIST");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");


            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.claimInterview).HasForeignKey<ClaimInterview>(t => t.ClaimId);
        }
    }
}


