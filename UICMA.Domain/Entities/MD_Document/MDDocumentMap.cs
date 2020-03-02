using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.MD_Document;

namespace UICMA.Domain.Entities.MD_DocumentMap
{
   public class MDDocumentMap
    {
        public MDDocumentMap(EntityTypeBuilder<MDDocument> builder)
        {
            builder.ToTable("MD_DOCUMENT_TBL");
            builder.HasKey(s => s.Id).HasName("MD_DOCUMENT_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.DocumentName).HasColumnName("DOCUMENT_NAME"); 
            builder.Property(s => s.DocumentStatus).HasColumnName("DOCUMENT_STATUS"); 
            builder.Property(s => s.DocumentDescription).HasColumnName("DOCUMENT_DESCRIPTION");
            builder.Property(s => s.IsMandatory).HasColumnName("IS_MANDATORY");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY"); 
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY"); 
        }
    }
}
