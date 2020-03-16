using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.New_ClaimMap
{
   public class ClaimMap
    {
       public ClaimMap(EntityTypeBuilder<Claim> builder)
        {
            builder.ToTable("CLAIM_TBL");
            builder.HasKey(s => s.Id).HasName("CLAIM_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.RequestNumber).HasColumnName("REQUEST_NUMBER");
            builder.Property(s => s.RequestTitle).HasColumnName("REQUEST_TITLE");
            builder.Property(s => s.Type).HasColumnName("TYPE");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.CurrentStage).HasColumnName("CURRENT_STAGE");
            builder.Property(s => s.Gender).HasColumnName("GENDER");
            builder.Property(s => s.EmployeeNumber).HasColumnName("EMPLOYEE_NUMBER");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.ReasonForSeparation).HasColumnName("REASON_FOR_SEPARATION");
            builder.Property(s => s.NewClaim).HasColumnName("NEW_CLAIM");
            builder.Property(s => s.AdditionalClaim).HasColumnName("ADDITIONAL_CLAIM");
            builder.Property(s => s.BenefitYearBeginning).HasColumnName("BENEFIT_YEAR_BEGINNING");
            builder.Property(s => s.DateMailedToEDD).HasColumnName("DATE_MAILED_TO_EDD");
            builder.Property(s => s.MailDate).HasColumnName("MAIL_DATE");
            builder.Property(s => s.EffectiveDateOfClaim).HasColumnName("EFFECTIVE_DATE_OF_CLAIM");
            builder.Property(s => s.LastDateWorked).HasColumnName("LAST_DATE_WORKED");
            builder.Property(s => s.DeadlineDate).HasColumnName("DEADLINE_DATE");
            builder.Property(s => s.ReceivedDate).HasColumnName("RECEIVED_DATE");
            builder.Property(s => s.Address).HasColumnName("ADDRESS");
            builder.Property(s => s.ProtestDecision).HasColumnName("PROTEST_DECISION");
            builder.Property(s => s.ClaimantStatus).HasColumnName("CLAIMANT_STATUS");
            builder.Property(s => s.BYB).HasColumnName("BYB");
            builder.Property(s => s.City).HasColumnName("CITY");
            builder.Property(s => s.State).HasColumnName("STATE");
            builder.Property(s => s.Zipcode).HasColumnName("ZIPCODE");
        }
    }
}