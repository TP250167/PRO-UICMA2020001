using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Templates;

namespace UICMA.Domain.Entities.TemplateMap
{
   public class TemplateMap
    {
        public TemplateMap(EntityTypeBuilder<Template> builder)
        {
            builder.ToTable("TEMPLATE_TBL");
            builder.HasKey(s => s.Id).HasName("TEMPLATE_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.TemplateName).HasColumnName("TEMPLATE_NAME");
            builder.Property(s => s.TemplateCategory).HasColumnName("TEMPLATE_CATEGORY");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.TemplateStatus).HasColumnName("TEMPLATE_STATUS");
            builder.Property(s => s.TemplateBodyContent).HasColumnName("TEMPLATE_BODY_CONTENT").HasColumnType("nvarchar(MAX)"); 
            builder.Property(s => s.TemplateAttachmentContent).HasColumnName("TEMPLATE_ATTACHMENT_CONTENT").HasColumnType("nvarchar(MAX)");
            builder.Property(s => s.TemplateType).HasColumnName("TEMPLATE_TYPE");
            builder.Property(s => s.TemplateDescription).HasColumnName("TEMPLATE_DESCRIPTION");
            builder.Property(s => s.LetterType).HasColumnName("LETTER_TYPE");
        }
    }
}
