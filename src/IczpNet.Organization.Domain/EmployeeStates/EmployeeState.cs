using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.Employees;
using System;
using System.Collections.Generic;

namespace IczpNet.Organization.EmployeeStates
{
    public class EmployeeState : BaseEntity<Guid>
    {
        public virtual bool IsStatic { get; set; }

        public virtual IEnumerable<Employee> EmployeeList { get; set; }
    }
}
