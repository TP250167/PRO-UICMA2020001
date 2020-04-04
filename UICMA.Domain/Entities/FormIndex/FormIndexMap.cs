using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Domain.Entities.FormIndex
{
   public class FormIndexMap
    {
        public FormIndexMap(EntityTypeBuilder<FormIndex> builder)
        {
            builder.ToTable("FORM_INDEX_MAPPING_TBL");
            builder.HasKey(s => s.Id).HasName("FORM_INDEX_MAPPING_ID");
            builder.Property(s => s.Formcode).HasColumnName("FORM_CODE");
            builder.Property(s => s.FieldName).HasColumnName("FIELD_NAME");
            builder.Property(s => s.PositionBottomRight).HasColumnName("POSITION_BOTTOM_RIGHT");
            builder.Property(s => s.PositionTopLeft).HasColumnName("POSITION_TOP_LEFT");
            builder.Property(s => s.Status).HasColumnName("STATUS");
            builder.Property(s => s.LineNumber).HasColumnName("LINE_NUMBER");
        }
    }
}
