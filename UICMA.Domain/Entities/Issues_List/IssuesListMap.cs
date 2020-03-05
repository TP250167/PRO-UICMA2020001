using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Issues_List;

namespace UICMA.Domain.Entities.Issues_ListMap
{
   public class IssuesListMap
    {
        public IssuesListMap(EntityTypeBuilder<IssuesList> builder)
        {
            builder.ToTable("ISSUES_LIST_TBL");
            builder.HasKey(s => s.Id).HasName("ISSUES_LIST_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.IssueCode).HasColumnName("ISSUE_CODE");
            builder.Property(s => s.IssueDecription).HasColumnName("ISSUE_DECRIPTION");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
        }
    }
}
