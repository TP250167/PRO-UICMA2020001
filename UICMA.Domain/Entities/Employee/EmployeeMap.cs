using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Employees;

namespace UICMA.Domain.Entities.EmployeeMap
{
   public class EmployeeMap
    {
        public EmployeeMap(EntityTypeBuilder<Employee> entityBuilder)
        {
            entityBuilder.ToTable("EMPLOYEE_TBL");
            entityBuilder.Property(t => t.EmployeeNumberCode).HasColumnName("EMP_NUM_CODE");
            entityBuilder.Property(t => t.MiddleName).HasColumnName("MIDDLE_NAME");
            entityBuilder.Property(t => t.FirstName).HasColumnName("FIRST_NAME");
            entityBuilder.Property(t => t.LastName).HasColumnName("LAST_NAME");
            entityBuilder.Property(t => t.InitialName).HasColumnName("INITIAL_NAME,");
            entityBuilder.Property(t => t.BirthDate).HasColumnName("BIRTH_DATE");
            entityBuilder.Property(t => t.BirthDay).HasColumnName("BIRTH_DAY");
            entityBuilder.Property(t => t.BirthMonth).HasColumnName("BIRTH_MONTH");
            entityBuilder.Property(t => t.BirthYear).HasColumnName("BIRTH_YEAR");
            entityBuilder.Property(t => t.TitleName).HasColumnName("TITLE_NAME");
            entityBuilder.Property(t => t.SecondTitleName).HasColumnName("SECOND_TITLE_NAME");
            entityBuilder.Property(t => t.OtherTitleName).HasColumnName("OTHER_TITLE_NAME");
            entityBuilder.Property(t => t.SecondName).HasColumnName("SECOND_NAME");
            entityBuilder.Property(t => t.TieBreaker).HasColumnName("TIE_BREAKER");
            entityBuilder.Property(t => t.GenderInd).HasColumnName("GENDER_IND");
            entityBuilder.Property(t => t.LanguageInd).HasColumnName("LANGUAGE_IND");
            entityBuilder.Property(t => t.EthnicityCode).HasColumnName("ETHNICITY_CODE");
            entityBuilder.Property(t => t.EthnicityDescription).HasColumnName("ETHNICITY_DESCR");
            entityBuilder.Property(t => t.HouseNumberStreetAddress).HasColumnName("HOUSE_NUM_STREET_ADDR");
            entityBuilder.Property(t => t.CityName).HasColumnName("CITY_NAME");
            entityBuilder.Property(t => t.PostalCode).HasColumnName("POSTAL_CODE");
            entityBuilder.Property(t => t.RegionCode).HasColumnName("REGION_CODE");
            entityBuilder.Property(t => t.CountryISOCode).HasColumnName("COUNTRY_ISO_CODE");
            entityBuilder.Property(t => t.TelephoneNumber).HasColumnName("TELEPHONE_NUMBER");
            entityBuilder.Property(t => t.SocialSecurityNumber).HasColumnName("SOCIAL_SECURITY_NUMBER");
            entityBuilder.Property(t => t.HighestDegreeCode).HasColumnName("HIGHEST_DEGREE_CODE");
            entityBuilder.Property(t => t.HighestDegreeName).HasColumnName("HIGHEST_DEGREE_NAME");
            entityBuilder.Property(t => t.OIDEmailAddress).HasColumnName("OID_EMAIL_ADDRESS");
            entityBuilder.Property(t => t.SAPUserIdCode).HasColumnName("SAP_USER_ID_CODE");
            entityBuilder.Property(t => t.SAPEmailAddress).HasColumnName("SAP_EMAIL_ADDRESS");
            entityBuilder.Property(t => t.EmpTypeCode).HasColumnName("EMP_TYPE_CODE");
            entityBuilder.Property(t => t.ActiveEmployeeIndicator).HasColumnName("ACTIVE_EMPLOYEE_INDICATOR");
            entityBuilder.Property(t => t.CreateDate).HasColumnName("CREATE_DATE");
            entityBuilder.Property(t => t.CreatedBy).HasColumnName("CREATED_BY");
            entityBuilder.Property(t => t.LastUpdateDate).HasColumnName("LAST_UPDATE_DATE");
            entityBuilder.Property(t => t.LastUpdateBy).HasColumnName("LAST_UPDATED_BY");
            entityBuilder.Property(t => t.SEIDCode).HasColumnName("SEID_CODE");
            entityBuilder.Property(s => s.JobCode).HasColumnName("JOD_CODE");
            entityBuilder.Property(s => s.JobTitle).HasColumnName("JOD_TITLE");
        }
    }
}
