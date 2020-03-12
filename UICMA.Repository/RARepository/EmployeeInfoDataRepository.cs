using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UICMA.Domain.Entities.Employees;

namespace UICMA.Repository.RARepository
{
   public class EmployeeInfoDataRepository : EntityBaseRepository<Employee>, IEmployeeInfoDataRepository
    {

        private readonly UICMAContext context;
        public EmployeeInfoDataRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
        public List<Employee> GetClassifiedEmployee()
        {
            return context.Employee.Where(s => s.EmpTypeCode.Contains("1")).ToList();
        }
        public List<Employee> GetUnclassifiedEmployee()
        {
            return context.Employee.Where(s => (s.EmpTypeCode.Contains("3") != s.EmpTypeCode.Contains ("3Y"))).ToList();
        }

        public List<Employee> GetTeacherAssitantEmployee()
        {
            return context.Employee.Where(s => s.EmpTypeCode.Contains("2F") ).ToList();
        }
        public List<Employee> GetSpecialEducation()
        {
            return context.Employee.Where(s => s.EmpTypeCode=="2UTK").ToList();
        }
        public List<Employee> GetSupportSchool()
        {
            return context.Employee.Where(s => (s.EmpTypeCode == "2USX" && s.EmpTypeCode == "2UTH" && s.EmpTypeCode == "2UTE")).ToList();
        }
    }
}
