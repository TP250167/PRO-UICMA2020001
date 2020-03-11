using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Notifications;

namespace UICMA.Domain.Entities.NotificationMap
{
   public class NotificationMap
    {
        public NotificationMap(EntityTypeBuilder<Notification> builder)
        {
            builder.ToTable("NOTIFICATION_TBL");
            builder.HasKey(s => s.Id).HasName("NOTIFY_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.NotifyAttachment).HasColumnName("NOTIFY_ATTACHMENT").HasColumnType("nvarchar(MAX)");
            builder.Property(s => s.NotifyBody).HasColumnName("NOTIFY_BODY").HasColumnType("nvarchar(MAX)");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.NotifyFrom).HasColumnName("NOTIFY_FROM");
            builder.Property(s => s.NotifyTo).HasColumnName("NOTIFY_TO");
            builder.Property(s => s.NotifyCC).HasColumnName("NOTIFY_CC");
            builder.Property(s => s.NotifyBCC).HasColumnName("NOTIFY_BCC");
            builder.Property(s => s.NotifySubject).HasColumnName("NOTIFY_SUBJECT");
            builder.Property(s => s.NotifyStatus).HasColumnName("NOTIFY_STATUS");
            builder.Property(s => s.RequestType).HasColumnName("REQUEST_TYPE");
            builder.Property(s => s.EmployeeNumber).HasColumnName("EMPLOYEE_NUMBER");
        }
    }
}
