using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Additional_Information;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Additional_InformationMap
{
   public class AdditionalInformationMap
    {
        public AdditionalInformationMap(EntityTypeBuilder<AdditionalInformation> builder)
        {
            builder.ToTable("ADDITIONAL_INFORMATION_TBL");
            builder.HasKey(s => s.Id).HasName("ADDITIONAL_INFORMATION_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.ControlNumber).HasColumnName("CONTROL_NUMBER");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.MailDate).HasColumnName("MAIL_DATE");
            builder.Property(s => s.ClaimEffectiveDate).HasColumnName("CLAIM_EFFECTIVE_DATE");
            builder.Property(s => s.PhoneNumber).HasColumnName("PHONE_NUMBER");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.EmployerName).HasColumnName("EMPLOYER_NAME");
            builder.Property(s => s.EmployerAddress).HasColumnName("EMPLOYER_ADDRESS");
            builder.Property(s => s.FormPath).HasColumnName("FORM_PATH");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");


            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.additionalInformation).HasForeignKey<AdditionalInformation>(t => t.ClaimId);
        }
    }
}
