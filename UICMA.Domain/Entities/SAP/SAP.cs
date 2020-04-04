using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Domain.Entities.SAP
{
    public class SAP : IBaseEntity
    {
        public Int64 Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string SocialSecurityNumber { get; set; }
    }
}
