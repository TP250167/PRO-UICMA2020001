using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.ALJ_Decision;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.ALJ_DecisionMap
{
   public class ALJDecisionMap
    {
        public ALJDecisionMap(EntityTypeBuilder<ALJDecision> builder)
        {
            builder.ToTable("ALJ_DECISION_TBL");
            builder.HasKey(s => s.Id).HasName("ALJ_DECISION_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.FormerlyCaseNumber).HasColumnName("FORMERLY_CASE_NUMBER");
            builder.Property(s => s.CaseNumber).HasColumnName("CASE_NUMBER");
            builder.Property(s => s.MailDate).HasColumnName("MAIL_DATE");
            builder.Property(s => s.BYBClaimDate).HasColumnName("BYB_CLAIM_DATE");
            builder.Property(s => s.ApplicationReopenDate).HasColumnName("APPLICATION_REOPEN_DATE");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.EmployerInfo).HasColumnName("EMPLOYER_INFO");
            builder.Property(s => s.ALJName).HasColumnName("ALJ_NAME");
            builder.Property(s => s.PlaceOfHearingDate).HasColumnName("PLACE_OF_HEARING_DATE");
            builder.Property(s => s.PlaceOfHearing).HasColumnName("PLACE_OF_HEARING");
            builder.Property(s => s.FormPath).HasColumnName("FORM_PATH");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.Decision).HasColumnName("DECISION");
            builder.Property(s => s.PartiesAppearing).HasColumnName("PARTIES_APPEARING");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");


            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.ALJdecision).HasForeignKey<ALJDecision>(t => t.ClaimId);

        }
    }
}
