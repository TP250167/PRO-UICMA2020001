using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;
using UICMA.Domain.Entities.Wages_Appeal;

namespace UICMA.Domain.Entities.Wages_AppealMap
{
   public class WagesAppealMap
    {
        public WagesAppealMap(EntityTypeBuilder<WagesAppeal> builder)
        {
            builder.ToTable("WAGES_APPEAL_TBL");
            builder.HasKey(s => s.Id).HasName("WAGES_APPEAL_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.Notes).HasColumnName("NOTES");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.LAUSDEligibilityInformation).HasColumnName("LAUSD_ELIGIBILITY_INFORMATION");
            builder.Property(s => s.LAUSDFaxDate).HasColumnName("LAUSD_FAX_DATE");
            builder.Property(s => s.BYBClaimDate).HasColumnName("BYB_CLAIM_DATE");
            builder.Property(s => s.FieldOfficeAddress).HasColumnName("FIELD_OFFICE_ADDRESS");
            builder.Property(s => s.LAUSDAccountNumber).HasColumnName("LAUSD_ACCOUNT_NUMBER");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");
            builder.Property(s => s.UserName).HasColumnName("USER_NAME");
            builder.Property(s => s.Signature).HasColumnName("SIGNATURE");
            builder.Property(s => s.Date).HasColumnName("DATE");
            builder.Property(s => s.UserPhoneNumber).HasColumnName("USER_PHONE_NUMBER");

            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.wagesAppeal).HasForeignKey<WagesAppeal>(t => t.ClaimId);
        }
    }
}
