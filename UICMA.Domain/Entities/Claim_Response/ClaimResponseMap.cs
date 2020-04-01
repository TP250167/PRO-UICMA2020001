using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Response;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Claim_ResponseMap
{
   public class ClaimResponseMap
    {
        public ClaimResponseMap(EntityTypeBuilder<ClaimResponse> builder)
        {
            builder.ToTable("CLAIM_RESPONSE_TBL");
            builder.HasKey(s => s.Id).HasName("CLAIM_RESPONSE_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.State).HasColumnName("STATE");
            builder.Property(s => s.City).HasColumnName("CITY");
            builder.Property(s => s.Zipcode).HasColumnName("ZIPCODE");
            builder.Property(s => s.Address).HasColumnName("ADDRESS");
            builder.Property(s => s.LAUSDMailDate).HasColumnName("LAUSD_MAIL_DATE");
            builder.Property(s => s.BYBClaimDate).HasColumnName("BYB_CLAIM_DATE");
            builder.Property(s => s.EffectiveDateOfClaim).HasColumnName("EFFECTIVE_DATE_OF_CLAIM");
            builder.Property(s => s.DueDate).HasColumnName("DUE_DATE");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.LAUSDResponse).HasColumnName("LAUSD_RESPONSE");
            builder.Property(s => s.RepresentativeName).HasColumnName("REPRESENTATIVE_NAME");
            builder.Property(s => s.PhoneNumber).HasColumnName("PHONE_NUMBER");
            builder.Property(s => s.Signature).HasColumnName("SIGNATURE");
            builder.Property(s => s.Title).HasColumnName("TITLE");
            builder.Property(s => s.PrintName).HasColumnName("PRINT_NAME");
            builder.Property(s => s.Date).HasColumnName("DATE");
            builder.Property(s => s.IssuesList).HasColumnName("ISSUES_LIST");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.RALetter).HasColumnName("RA_LETTER").HasDefaultValue(false);
            builder.Property(s => s.ProtestPage).HasColumnName("PROTEST_PAGE").HasDefaultValue(false);
            builder.Property(s => s.EEContract).HasColumnName("EE_CONTRACT").HasDefaultValue(false);
            builder.Property(s => s.TimeWageReport).HasColumnName("TIME_WAGE_REPORT").HasDefaultValue(false);
            builder.Property(s => s.StatementOfCharges).HasColumnName("STATEMENT_OF_CHARGES").HasDefaultValue(false);
            builder.Property(s => s.OfferLetter).HasColumnName("OFFER_LETTER").HasDefaultValue(false);
            builder.Property(s => s.SubCalender).HasColumnName("SUB_CALENDER").HasDefaultValue(false);
            builder.Property(s => s.WarningLetters).HasColumnName("WARNING_LETTERS").HasDefaultValue(false);
            builder.Property(s => s.Other).HasColumnName("OTHER").HasDefaultValue(false);
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");

            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.claimResponse).HasForeignKey<ClaimResponse>(t => t.ClaimId);
        }
    }
}
