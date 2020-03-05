using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Associated_Documents;
using UICMA.Domain.Entities.MD_Document;
using UICMA.Domain.Entities.MD_Form;

namespace UICMA.Domain.Entities.Associated_DocumentsMap
{
   //public class AssociatedDocumentsMap
   // {
   //     public AssociatedDocumentsMap(EntityTypeBuilder<AssociatedDocuments> builder)
   //     {
   //         builder.ToTable("ASSOCIATED_DOCUMENTS_TBL");
   //     //    builder.HasKey(s => s.Id).HasName("ASSOCIATED_DOCUMENTS_ID");
   //     //    builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
   //      //   builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
   //         builder.Property(s => s.DocumentId).HasColumnName("DOCUMENT_ID");
   //         builder.Property(s => s.FormId).HasColumnName("FORM_ID");
   //      //   builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
   //      //   builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");

   //         //builder.HasMany(c => c.MDDocument);
   //         //builder.HasOne(e => e.MDForms);
   //     }
   // }
}

