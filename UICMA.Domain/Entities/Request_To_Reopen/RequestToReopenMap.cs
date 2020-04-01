using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;
using UICMA.Domain.Entities.Request_To_Reopen;

namespace UICMA.Domain.Entities.Request_To_ReopenMap
{
   public class RequestToReopenMap
    {
        public RequestToReopenMap(EntityTypeBuilder<RequestToReopen> builder)
        {
            builder.ToTable("REQUEST_TO_REOPEN_TBL");
            builder.HasKey(s => s.Id).HasName("REQUEST_TO_REOPEN_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.AdministrativeLawJudgeServer).HasColumnName("ADMIN_LAW_JUDGE_SERVER");
            builder.Property(s => s.City).HasColumnName("CITY");
            builder.Property(s => s.State).HasColumnName("STATE");
            builder.Property(s => s.Zipcode).HasColumnName("ZIPCODE");
            builder.Property(s => s.HearingTime).HasColumnName("HEARING_TIME");
            builder.Property(s => s.AppealOfficeAddress).HasColumnName("APPEAL_OFFICE_ADDRESS");
            builder.Property(s => s.RequestReason).HasColumnName("REQUEST_REASON");
            
            builder.Property(s => s.HearingDate).HasColumnName("HEARING_DATE");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.Employer).HasColumnName("EMPLOYER");
            builder.Property(s => s.CaseNumber).HasColumnName("CASE_NUMBER");
            builder.Property(s => s.Signature).HasColumnName("SIGNATURE");
            builder.Property(s => s.MailDate).HasColumnName("MAIL_DATE");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");
            builder.Property(s => s.MailDate).HasColumnName("MAIL_DATE");
            builder.Property(s => s.AccountNumber).HasColumnName("ACCOUNT_NUMBER");

            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.requestToReopen).HasForeignKey<RequestToReopen>(t => t.ClaimId);
        }
    }
}
