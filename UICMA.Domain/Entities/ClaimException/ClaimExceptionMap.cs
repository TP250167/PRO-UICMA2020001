using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.ClaimExceptions;

namespace UICMA.Domain.Entities.ClaimExceptionMap
{
   public class ClaimExceptionMap
    {
        public ClaimExceptionMap(EntityTypeBuilder<ClaimException> builder)
        {
            builder.ToTable("CLAIM_EXCEPTION_TBL");
            builder.HasKey(s => s.Id).HasName("CLAIM_EXCEPTION_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.ExceptionDate).HasColumnName("EXCEPTION_DATE");
            builder.Property(s => s.ExceptionReason).HasColumnName("EXCEPTION_REASON");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");
            builder.Property(s => s.DocumentId).HasColumnName("DOCUMENT_ID");
            builder.Property(s => s.FormId).HasColumnName("FORM_ID");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");

          //  builder.HasOne(t => t.MDDocument).WithMany(s => s.ClaimExceptions).HasForeignKey(t => t.DocumentId);
          //  builder.HasOne(t => t.MDForm).WithMany(s => s.ClaimExceptions).HasForeignKey(t => t.FormId);
        }
    }
}
