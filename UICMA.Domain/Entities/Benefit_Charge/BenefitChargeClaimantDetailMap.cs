using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Benefit_Charge;
using UICMA.Domain.Entities.Benefit_Charge_ClaimantDetail;

namespace UICMA.Domain.Entities.Benefit_Charge_Claimant_DetailMap
{
  public class BenefitChargeClaimantDetailMap
    {
        public BenefitChargeClaimantDetailMap(EntityTypeBuilder<BenefitChargeClaimantDetail> builder)
        {
            builder.ToTable("BEN_CHAR_CLAIMANT_DETAIL_TBL");
            builder.HasKey(s => s.Id).HasName("BEN_CHAR_CLAIMANT_DETAIL_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.ChargeQuarterDate).HasColumnName("CHARGE_QUARTER_DATE");
            builder.Property(s => s.EmployerCharge).HasColumnName("EMPLOYER_CHARGE").HasColumnType("decimal(16,2)");
            builder.Property(s => s.ChargeCode).HasColumnName("CHARGE_CODE");
            builder.Property(s => s.PCMCode).HasColumnName("PCM_CODE");
            builder.Property(s => s.ClaimType).HasColumnName("CLAIM_TYPE");
            builder.Property(s => s.ClaimDate).HasColumnName("CLAIM_DATE");
            builder.Property(s => s.ClaimantSSN).HasColumnName("CLAIMANT_SSN");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");
            builder.Property(s => s.FormId).HasColumnName("FORM_ID");

            builder.HasOne<BenefitCharge>(s => s.benefitCharge).WithMany(x =>x.benefitChargeClaimantDetail).HasForeignKey(s => s.FormId);
        }
    }
}
