using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;
using UICMA.Domain.Entities.Response_to_Employer;

namespace UICMA.Domain.Entities.Response_to_EmployerMap
{
  public  class ResponseToEmployerMap
    {
        public ResponseToEmployerMap(EntityTypeBuilder<ResponseToEmployer> builder)
        {
            builder.ToTable("RESPONSE_TO_EMPLOYER_TBL");
            builder.HasKey(s => s.Id).HasName("RESPONSE_TO_EMPLOYER_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.DateMailed).HasColumnName("DATE_MAILED");
            builder.Property(s => s.BenefitYearBeganDate).HasColumnName("BENEFIT_YEAR_BEGAN_DATE");
            builder.Property(s => s.FormPath).HasColumnName("FORM_PATH");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");

            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.responsetoEmployer).HasForeignKey<ResponseToEmployer>(t => t.ClaimId);
        }
    }
}
