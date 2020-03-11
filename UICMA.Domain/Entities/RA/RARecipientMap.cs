using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RARecipients;

namespace UICMA.Domain.Entities.RARecipientMap
{
   public class RARecipientMap
    {
        public RARecipientMap(EntityTypeBuilder<RARecipient> builder)
        {
            builder.ToTable("RA_RECIPIENT_TBL");
            builder.HasKey(s => s.Id).HasName("RA_RECIPIENT_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.EmployeeEmail).HasColumnName("EMPLOYEE_EMAIL");
            builder.Property(s => s.EmployeeName).HasColumnName("EMPLOYEE_NAME");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.EmployeeNumber).HasColumnName("EMPLOYEE_NUMBER");
            builder.Property(s => s.EmailReferenceNumber).HasColumnName("EMAIL_REFERENCE_NUMBER");
            builder.Property(s => s.NotifiedSentOn).HasColumnName("NOTIFIED_SENT_ON");
            builder.Property(s => s.FailedOn).HasColumnName("FAILED_ON");
            builder.Property(s => s.Status).HasColumnName("STATUS");
            builder.Property(s => s.DeliveredOn).HasColumnName("DELIVERED_ON");
            builder.Property(s => s.IsSucessfullyDeliver).HasColumnName("IS_SUCESSFULLY_DELIVER").HasDefaultValue(false);
            builder.Property(s => s.IsSentMailCaptured).HasColumnName("IS_SENT_MAIL_CAPTURED").HasDefaultValue(false);
            builder.Property(s => s.IsDeliveryMailCaptured).HasColumnName("IS_DELIVERY_MAIL_CAPTURED").HasDefaultValue(false);
            builder.Property(s => s.IsRetry).HasColumnName("IS_RETRY").HasDefaultValue(false);
            builder.Property(s => s.DeliveryNotice).HasColumnName("DELIVERY_NOTICE").HasColumnType("nvarchar(MAX)");
        }
    }
}
