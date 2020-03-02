using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.MD_Form;

namespace UICMA.Domain.Entities.MD_FormMap
{
   public class MDFormMap
    {
        public MDFormMap(EntityTypeBuilder<MDForm> builder)
        {
            builder.ToTable("MD_FORM_TBL");
            builder.HasKey(s => s.Id).HasName("MD_FORM_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.FormName).HasColumnName("FORM_NAME"); 
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE"); 
            builder.Property(s => s.FormStatus).HasColumnName("FORM_STATUS"); 
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY"); ;
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY"); 

        }
    }
}
