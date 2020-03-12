using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;
using UICMA.Domain.Entities.Writs;

namespace UICMA.Domain.Entities.WritMap
{
   public class WritMap
    {
        public WritMap(EntityTypeBuilder<Writ> builder)
        {
            builder.ToTable("WRIT_TBL");
            builder.HasKey(s => s.Id).HasName("WRIT_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.Notes).HasColumnName("NOTES");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");
            builder.Property(s => s.MailDate).HasColumnName("MAIL_DATE");

            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.writ).HasForeignKey<Writ>(t => t.ClaimId);
        }
    }
}
