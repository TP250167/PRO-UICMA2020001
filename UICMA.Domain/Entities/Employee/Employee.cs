using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UICMA.Domain.Entities.Employees
{
   public class Employee :IBaseEntity
    {
        

        [NotMapped]
        public Int64 Id { get; set; }
        [Key]
        public string EmployeeNumberCode { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public string InitialName { get; set; }
        public DateTime? BirthDay { get; set; }
        public string BirthDate { get; set; }
        public string BirthYear { get; set; }
        public string BirthMonth { get; set; }
        public string TitleName { get; set; }
        public string SecondTitleName { get; set; }
        public string OtherTitleName { get; set; }
        public string SecondName { get; set; }
        public string TieBreaker { get; set; }
        public string GenderInd { get; set; }
        public string LanguageInd { get; set; }
        public string EthnicityCode { get; set; }
        public string EthnicityDescription { get; set; }
        public string HouseNumberStreetAddress { get; set; }
        public string CityName { get; set; }
        public string PostalCode { get; set; }
        public string RegionCode { get; set; }
        public string CountryISOCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string SEIDCode { get; set; }
        public string HighestDegreeCode { get; set; }
        public string HighestDegreeName { get; set; }
        public string OIDEmailAddress { get; set; }
        public string SAPUserIdCode { get; set; }
        public string SAPEmailAddress { get; set; }
        public string EmpTypeCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ActiveEmployeeIndicator { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string LastUpdateBy { get; set; }
    }
}
