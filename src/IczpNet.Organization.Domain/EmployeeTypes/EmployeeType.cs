using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.Employees;
using System;
using System.Collections.Generic;

namespace IczpNet.Organization.EmployeeTypes
{
    public class EmployeeType : BaseEntity<Guid>
    {
        public virtual IEnumerable<Employee> EmployeeList { get; set; }
    }
}
