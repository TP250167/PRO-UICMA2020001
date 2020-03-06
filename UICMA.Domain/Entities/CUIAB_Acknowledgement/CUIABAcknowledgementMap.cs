using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.CUIAB_Acknowledgement;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.CUIAB_AcknowledgementMap
{
   public class CUIABAcknowledgementMap
    {
        public CUIABAcknowledgementMap(EntityTypeBuilder<CUIABAcknowledgement> builder)
        {
            builder.ToTable("CUIAB_ACKNOWLEDGEMENT_TBL");
            builder.HasKey(s => s.Id).HasName("CUIAB_ACKNOWLEDGEMENT_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.Address).HasColumnName("ADDRESS");
            builder.Property(s => s.CUIABAddress).HasColumnName("CUIAB_ADDRESS");
            builder.Property(s => s.LAUSDAddress).HasColumnName("LAUSD_ADDRESS");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.ABCaseNumber).HasColumnName("AB_CASE_NUMBER");
            builder.Property(s => s.Appellant).HasColumnName("APPELLANT");
            builder.Property(s => s.ALJDecisionNumber).HasColumnName("ALJ_DECISION_NUMBER");
            builder.Property(s => s.FormPath).HasColumnName("FORM_PATH");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.DateMailed).HasColumnName("DATE_MAILED");
            builder.Property(s => s.AccountNumber).HasColumnName("ACCOUNT_NUMBER");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");


            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.acknowledgement).HasForeignKey<CUIABAcknowledgement>(t => t.ClaimId);
        }
    }
}
