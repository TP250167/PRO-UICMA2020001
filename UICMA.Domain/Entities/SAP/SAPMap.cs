using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Domain.Entities.SAP
{
    public class SAPMap
    {
        public SAPMap(EntityTypeBuilder<SAP> builder)
        {
            builder.ToTable("SAP_TBL");
            builder.HasKey(s => s.Id).HasName("SAP_ID");
            builder.Property(s => s.EmployeeNumber).HasColumnName("EMPLOYEE_NUMBER");
            builder.Property(s => s.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
        }
    }
}