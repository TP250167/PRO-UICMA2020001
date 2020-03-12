using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RAAssociatedDocuments;

namespace UICMA.Domain.Entities.RAAssociatedDocumentMap
{
   public class RAAssociatedDocumentMap
    {
        public RAAssociatedDocumentMap(EntityTypeBuilder<RAAssociatedDocument> builder)
        {
            builder.ToTable("RA_ASSOCIATED_DOCUMENT_TBL");
            builder.HasKey(s => s.Id).HasName("RA_ASSOCIATED_DOCUMENT_ID");
            builder.Property(s => s.Type).HasColumnName("TYPE");
            builder.Property(s => s.DocumentationPath).HasColumnName("DOCUMENTATION_PATH");
            builder.Property(s => s.RAScheduleId).HasColumnName("RA_SCHEDULE_ID");
            builder.Property(s => s.RecipientId).HasColumnName("RECIPIENT_ID");

            builder.HasOne(t => t.RAschedule).WithMany(s => s.RAassociatedDocument).HasForeignKey(t => t.RAScheduleId).HasConstraintName("ASS_DOC_SCHEDULE_ID");
            builder.HasOne(t => t.RArecipient).WithMany(s => s.RAassociatedDocument).HasForeignKey(t => t.RecipientId);

        }
    }
}
