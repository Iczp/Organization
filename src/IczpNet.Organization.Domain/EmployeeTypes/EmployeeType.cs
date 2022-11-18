using IczpNet.Organization.Bases;
using IczpNet.Organization.Employees;
using System;
using System.Collections.Generic;

namespace IczpNet.Organization.EmployeeTypes
{
    public class EmployeeType : BaseEntity<Guid>
    {
        public virtual bool IsStatic { get; set; }
        public virtual IEnumerable<Employee> EmployeeList { get; set; }
    }
}
