using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.ExtractingIndexValues;

namespace UICMA.Domain.Entities.ExtractingIndexValueMap
{
   public class ExtractingIndexValueMap
    {
        public ExtractingIndexValueMap(EntityTypeBuilder<ExtractingIndexValue> builder)
        {

            builder.ToTable("EXTRACTING_INDEX_VALUES_TBL");
            builder.HasKey(s => s.Id).HasName("EXTRACTING_INDEX_VALUES_ID");
            builder.Property(s => s.FormNumber).HasColumnName("FORM_NUMBER");
            builder.Property(s => s.FieldName).HasDefaultValue(DateTime.Now).HasColumnName("FIELD_NAME");
            builder.Property(s => s.PositionTopLeft).HasColumnName("POSITION_TOP_RIGHT");
            builder.Property(s => s.PositionBottomRight).HasColumnName("POSITION_BOTTOM_RIGHT");
            builder.Property(s => s.Status).HasColumnName("STATUS");
        }
    }
}
