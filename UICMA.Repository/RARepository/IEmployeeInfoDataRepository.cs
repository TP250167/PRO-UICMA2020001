using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Employees;

namespace UICMA.Repository.RARepository
{
  public interface IEmployeeInfoDataRepository: IEntityBaseRepository<Employee>
    {
        List<Employee> GetClassifiedEmployee();
        List<Employee> GetUnclassifiedEmployee();
        List<Employee> GetTeacherAssitantEmployee();
        List<Employee> GetSpecialEducation();
        List<Employee> GetSupportSchool();
    }
}
