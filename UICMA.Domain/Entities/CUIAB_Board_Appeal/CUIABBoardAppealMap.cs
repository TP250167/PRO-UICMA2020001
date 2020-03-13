using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.CUIAB_Board_Appeal;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.CUIAB_Board_AppealMap
{
   public class CUIABBoardAppealMap
    {
        public CUIABBoardAppealMap(EntityTypeBuilder<CUIABBoardAppeal> builder)
        {
            builder.ToTable("CUIAB_BOARD_APPEAL_TBL");
            builder.HasKey(s => s.Id).HasName("CUIAB_BOARD_APPEAL_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.UserDate).HasColumnName("USER_DATE");
            builder.Property(s => s.CUIABAddress).HasColumnName("CUIAB_ADDRESS");
            builder.Property(s => s.AppellantPhoneNumber).HasColumnName("APPELLANT_PHONE_NUMBER");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.AppellantFaxNumber).HasColumnName("APPELLANT_FAX_NUMBER");
            builder.Property(s => s.AppellantMailAddress).HasColumnName("APPELLANT_MAIL_ADDRESS");
            builder.Property(s => s.AppellantName).HasColumnName("APPELLANT_NAME");
            builder.Property(s => s.ALJDecisionCaseNumber).HasColumnName("ALJ_DECISION_CASE_NUMBER");
            builder.Property(s => s.ALJDecisionDate).HasColumnName("ALJ_DECISION_DATE");
            builder.Property(s => s.LAUSDEmailAddress).HasColumnName("LAUSD_EMAIL_ADDRESS");
            builder.Property(s => s.CUIABPermission).HasColumnName("CUIAB_PERMISSION").HasDefaultValue(false);
            builder.Property(s => s.CellPhoneNumber).HasColumnName("CELL_PHONE_NUMBER");
            builder.Property(s => s.EmployerAccountNumber).HasColumnName("EMPLOYER_ACCOUNT_NUMBER");
            builder.Property(s => s.DisagreeReason).HasColumnName("DISAGREE_REASON");
            builder.Property(s => s.AppellantAgentRepAddress).HasColumnName("APPELLANT_AGENT_REP_ADDRESS");
            builder.Property(s => s.AppellantAgentRepName).HasColumnName("APPELLANT_AGENT_REP_NAME");
            builder.Property(s => s.AppellantAgentRepSignature).HasColumnName("APPELLANT_AGENT_REP_SIGNATURE");
            builder.Property(s => s.AppellantAgentRepSignedDate).HasColumnName("APPELLANT_AGENT_REP_SIGNED_DT");
            builder.Property(s => s.PartyFilingAppeal).HasColumnName("PARTY_FILING_APPEAL");
            builder.Property(s => s.FormPath).HasColumnName("FORM_PATH");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");
            builder.Property(s => s.LAUSDFaxDate).HasColumnName("LAUSD_FAX_DATE");
            builder.Property(s => s.UserPrintName).HasColumnName("USER_PRINT_NAME");
            builder.Property(s => s.UserPhoneNumber).HasColumnName("USER_PHONE_NUMBER");
            builder.Property(s => s.UserSignature).HasColumnName("USER_SIGNATURE");
            builder.Property(s => s.UserTitle).HasColumnName("USER_TITLE");
            builder.Property(s => s.LAUSDAccountNumber).HasColumnName("LAUSD_ACCOUNT_NUMBER");
            builder.Property(s => s.BYBClaimDate).HasColumnName("BYB_CLAIM_DATE");
            builder.Property(s => s.AppealStatement).HasColumnName("APPEAL_STATEMENT");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.CaseNumber).HasColumnName("CASE_NUMBER");

            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.CUIABboardAppeal).HasForeignKey<CUIABBoardAppeal>(t => t.ClaimId);
        }
    }
}
