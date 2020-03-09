using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Form_Document;
using UICMA.Domain.Entities.MD_Document;
using UICMA.Domain.Entities.MD_Form;

namespace UICMA.Domain.Entities.Form_Document_Map
{
  public  class FormDocumentMap
    {
        public FormDocumentMap(EntityTypeBuilder<FormDocument> builder)
        {
            builder.ToTable("sample_TBL");
            builder.HasKey(s => s.Id).HasName("testttt_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.Channel).HasColumnName("STATE");
            builder.Property(s => s.ReceivedDate).HasColumnName("CITY");
            builder.Property(s => s.UploadFileName).HasColumnName("ZIPsfsdfCODE");
            builder.Property(s => s.ClaimId).HasColumnName("ClaimmY");
            builder.Property(s => s.FormId).HasColumnName("formmmm");
            builder.Property(s => s.DocumentId).HasColumnName("documenttttt");
            builder.Property(s => s.CreatedBy).HasColumnName("ZIPCODE");



        }
    }
}
