using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Determination_Appeal;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Determination_AppealMap
{
   public class DeterminationAppealMap
    {
        public DeterminationAppealMap(EntityTypeBuilder<DeterminationAppeal> builder)
        {
            builder.ToTable("DETERMINATION_APPEAL_TBL");
            builder.HasKey(s => s.Id).HasName("DETERMINATION_APPEAL_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.Notes).HasColumnName("NOTES");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.NeedTranslator).HasColumnName("NEED_TRANSLATOR").HasDefaultValue(false);
            builder.Property(s => s.TranslatorLanguage).HasColumnName("TRANSLATOR_LANGUAGE");
            builder.Property(s => s.EDDOfficeAddress).HasColumnName("EDD_OFFICE_ADDRESS");
            builder.Property(s => s.AppellantAddress).HasColumnName("APPELLANT_ADDRESS");
            builder.Property(s => s.AppellantEmail).HasColumnName("APPELLANT_EMAIL");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");
            builder.Property(s => s.AppellantCellNo).HasColumnName("APPELLANT_CELL_NUMBER");
            builder.Property(s => s.AppellantFaxNo).HasColumnName("APPELLANT_FAX_NUMBER");
            builder.Property(s => s.AppellantTelephoneNo).HasColumnName("APPELLANT_TELEPHONE_NUMBER");
            builder.Property(s => s.AuthorizeToSendEmail).HasColumnName("AUTHORIZE_TO_SEND_EMAIL").HasDefaultValue(false);
            builder.Property(s => s.AuthorizeToSendText).HasColumnName("AUTHORIZE_TO_SEND_TEXT").HasDefaultValue(false);
            builder.Property(s => s.EmployerAccountNumber).HasColumnName("EMPLOYER_ACCOUNT_NUMBER");
            builder.Property(s => s.AgentAddress).HasColumnName("AGENT_ADDRESS");
            builder.Property(s => s.AgentName).HasColumnName("AGENT_NAME");
            builder.Property(s => s.AgentCity).HasColumnName("AGENT_CITY");
            builder.Property(s => s.AgentState).HasColumnName("AGENT_STATE");
            builder.Property(s => s.AgentZipcode).HasColumnName("AGENT_ZIPCODE");
            builder.Property(s => s.AppellantState).HasColumnName("APPELLANT_STATE");
            builder.Property(s => s.AppellantCity).HasColumnName("APPELLANT_CITY");
            builder.Property(s => s.AppellantZipcode).HasColumnName("APPELLANT_ZIPCODE");
            builder.Property(s => s.FormDate).HasColumnName("FORM_DATE");
            builder.Property(s => s.Signature).HasColumnName("SIGNATURE");
            builder.Property(s => s.AppellantStatementComments).HasColumnName("APPELLANT_STATEMENT_COMMENTS");
            builder.Property(s => s.AppellantStatementNoticeDate).HasColumnName("APPELLANT_STATEM_NOTICE_DATE");

            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.determinationAppeal).HasForeignKey<DeterminationAppeal>(t => t.ClaimId);
        }
    }
}
