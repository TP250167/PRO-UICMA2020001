using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Form_Document;
using UICMA.Domain.Entities.MD_Document;
using UICMA.Domain.Entities.MD_Form;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Form_Document_Map
{
  public  class FormDocumentMap
    {
        public FormDocumentMap(EntityTypeBuilder<FormDocument> builder)
        {
            builder.ToTable("FORM_DOCUMENT_MAP_TBL");
            builder.HasKey(s => s.Id).HasName("FORM_DOCUMENT_MAP_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.Channel).HasColumnName("CHANNEL");
            builder.Property(s => s.ReceivedDate).HasColumnName("RECEIVED_DATE");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID"); 
            builder.Property(s => s.DocumentId).HasColumnName("DOCUMENT_ID");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.DocumentType).HasColumnName("DOCUMENT_TYPE");
            builder.Property(s => s.DocumentName).HasColumnName("DOCUMENT_NAME");
            builder.Property(s => s.Stage).HasColumnName("STAGE");
            builder.Property(s => s.IsSharepointPushed).HasColumnName("IS_SHAREPOINT_PUSHED").HasDefaultValue(false);

            //builder.HasOne(t => t.MDDocument).WithMany(s => s.FormDocuments).HasForeignKey(t => t.DocumentId);
            //builder.HasOne(t => t.MDForm).WithMany(s => s.FormDocuments).HasForeignKey(t => t.FormId);
            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.formDocument).HasForeignKey<FormDocument>(t => t.ClaimId);
        }
    }
}
