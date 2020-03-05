using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Appeal;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Claim_AppealMap
{
  public  class ClaimAppealMap
    {
        public  ClaimAppealMap(EntityTypeBuilder<ClaimAppeal> builder)
        {
            builder.ToTable("CLAIM_APPEAL_TBL");
            builder.HasKey(s => s.Id).HasName("CLAIM_APPEAL_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.State).HasColumnName("STATE");
            builder.Property(s => s.City).HasColumnName("CITY");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.Address).HasColumnName("ADDRESS");
            builder.Property(s => s.Zipcode).HasColumnName("ZIPCODE");
            builder.Property(s => s.LAUSDFaxDate).HasColumnName("LAUSD_FAX_DATE");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.BYBClaimDate).HasColumnName("BYB_CLAIM_DATE"); 
            builder.Property(s => s.FormDate).HasColumnName("FORM_DATE");
            builder.Property(s => s.LAUSDAccountNumber).HasColumnName("LAUSD_ACCOUNT_NUMBER"); 
            builder.Property(s => s.LAUSDEligibilityInformation).HasColumnName("LAUSD_ELIGIBILITY_INFORMATION");
            builder.Property(s => s.RepresentativeName).HasColumnName("REPRESENTATIVE_NAME"); 
            builder.Property(s => s.PhoneNumber).HasColumnName("PHONE_NUMBER");
            builder.Property(s => s.Signature).HasColumnName("SIGNATURE");
            builder.Property(s => s.Title).HasColumnName("TITLE");
            builder.Property(s => s.Date).HasColumnName("DATE");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");

            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.claimAppeal).HasForeignKey<ClaimAppeal>(t => t.ClaimId);
        }
    }
}

