using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.New_Claim;
using UICMA.Domain.Entities.NoticeOfWages;

namespace UICMA.Domain.Entities.WagesMap
{
   public class WagesMap
    {
        public WagesMap(EntityTypeBuilder<Wages> builder)
        {

            builder.ToTable("WAGES_TBL");
            builder.HasKey(s => s.Id).HasName("WAGES_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.ClaimantName).HasColumnName("CLAIMANT_NAME");
            builder.Property(s => s.Notes).HasColumnName("NOTES");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            builder.Property(s => s.OtherSSN).HasColumnName("OTHER_SSN");
            builder.Property(s => s.ClaimDate).HasColumnName("CLAIMDATE");
            builder.Property(s => s.FieldOfficePhoneNo).HasColumnName("FIELD_OFFICE_PHONE_NUMBER");
            builder.Property(s => s.FieldOfficeAddress).HasColumnName("FIELD_OFFICE_ADDRESS");
            builder.Property(s => s.PostmarkedResponseDate).HasColumnName("POSTMARKED_RESPONSE_DATE");
            builder.Property(s => s.FormCode).HasColumnName("FORM_CODE");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");
            builder.Property(s => s.WagesReport).HasColumnName("WAGES_REPORT");
            builder.Property(s => s.TotalWagesForAllEmployees).HasColumnName("TOTAL_WAGES_FOR_ALL_EMPLOYEES");
            builder.Property(s => s.TotalWagesForEmployee).HasColumnName("TOTAL_WAGES_FOR_EMPLOYEE");
            builder.Property(s => s.BenefitChargeableReserveAccount).HasColumnName("BENEFIT_CHARGE_RESERVE_ACC");
            builder.Property(s => s.ClaimantWeeklyBenefitAmount).HasColumnName("CLAIMANT_WEEKLY_BENEFIT_AMT");
            builder.Property(s => s.WagesQuarter1Amount).HasColumnName("WAGES_QUARTER1_AMOUNT");
            builder.Property(s => s.WagesQuarter2Amount).HasColumnName("WAGES_QUARTER2_AMOUNT");
            builder.Property(s => s.WagesQuarter3Amount).HasColumnName("WAGES_QUARTER3_AMOUNT");
            builder.Property(s => s.WagesQuarter4Amount).HasColumnName("WAGES_QUARTER4_AMOUNT");
            builder.Property(s => s.WagesQuarter1Date).HasColumnName("WAGES_QUARTER1_DATE");
            builder.Property(s => s.WagesQuarter2Date).HasColumnName("WAGES_QUARTER2_DATE");
            builder.Property(s => s.WagesQuarter3Date).HasColumnName("WAGES_QUARTER3_DATE");
            builder.Property(s => s.WagesQuarter4Date).HasColumnName("WAGES_QUARTER4_DATE");

            builder.HasOne<Claim>(s => s.claim).WithOne(x => x.wages).HasForeignKey<Wages>(t => t.ClaimId);
        }

    }
}
