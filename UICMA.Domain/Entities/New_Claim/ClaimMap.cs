using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.New_ClaimMap
{
   public class ClaimMap
    {
       public ClaimMap(EntityTypeBuilder<Claim> builder)
        {
            builder.ToTable("CLAIM_TBL");
            builder.HasKey(s => s.Id).HasName("CLAIM_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.RequestNumber).HasColumnName("REQUEST_NUMBER");
            builder.Property(s => s.RequestTitle).HasColumnName("REQUEST_TITLE");
            builder.Property(s => s.Type).HasColumnName("TYPE");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.CurrentStage).HasColumnName("CURRENT_STAGE");
            builder.Property(s => s.Gender).HasColumnName("GENDER");
            builder.Property(s => s.EmployeeNumber).HasColumnName("EMPLOYEE_NUMBER");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY"); ;
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
        }
    }
}
