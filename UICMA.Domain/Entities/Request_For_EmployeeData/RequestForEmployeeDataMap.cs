using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;
using UICMA.Domain.Entities.Request_For_EmployeeData;

namespace UICMA.Domain.Entities.Request_For_EmployeeDataMap
{
   public class RequestForEmployeeDataMap
    {
        public RequestForEmployeeDataMap(EntityTypeBuilder<RequestForEmployeeData> builder)
        {
            builder.ToTable("REQUEST_FOR_EMPLOYEE_DATA_TBL");
            builder.HasKey(s => s.Id).HasName("REQUEST_FOR_EMPLOYEE_DATA_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.Notes).HasColumnName("NOTES");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.UserCompletedBy).HasColumnName("USER_COMPLETED_BY");
            builder.Property(s => s.BYBClaimDate).HasColumnName("BYB_CLAIM_DATE");
            builder.Property(s => s.UserCompletedDate).HasColumnName("USER_COMPLETED_DATE");
            builder.Property(s => s.UserTitle).HasColumnName("USER_TITLE");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");
            builder.Property(s => s.Date).HasColumnName("DATE");
            builder.Property(s => s.UserTelephoneNumber).HasColumnName("USER_TELEPHONE_NUMBER");

            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.requestForEmployeeData).HasForeignKey<RequestForEmployeeData>(t => t.ClaimId);
        }
    }
}
