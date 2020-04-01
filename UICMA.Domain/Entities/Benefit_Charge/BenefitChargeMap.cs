using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Benefit_Charge;
using UICMA.Domain.Entities.New_Claim;

namespace UICMA.Domain.Entities.Benefit_ChargeMap
{
   public class BenefitChargeMap
    {
        public BenefitChargeMap(EntityTypeBuilder<BenefitCharge> builder)
        {
            builder.ToTable("BENEFIT_CHARGE_TBL");
            builder.HasKey(s => s.Id).HasName("BENEFIT_CHARGE_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.LetterId).HasColumnName("LETTER_ID");
            builder.Property(s => s.Notes).HasColumnName("NOTES");
            builder.Property(s => s.AccountId).HasColumnName("ACCOUNT_ID");
            builder.Property(s => s.IssuedDate).HasColumnName("ISSUED_DATE");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.AmountPaidByFiscalYear).HasColumnName("AMOUNT_PAID_BY_FISCAL_YEAR");
            builder.Property(s => s.AmountPaidByBYB).HasColumnName("AMOUNT_PAID_BY_BYB");
            builder.Property(s => s.ActualAmountPaid).HasColumnName("ACTUAL_AMOUNT_PAID");
            builder.Property(s => s.MaxAmountReceived).HasColumnName("MAX_AMOUNT_RECEIVED");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");

            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.benefitCharge).HasForeignKey<BenefitCharge>(t => t.ClaimId);
        }
    }
}
