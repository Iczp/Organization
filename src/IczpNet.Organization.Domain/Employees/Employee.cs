using IczpNet.Organization.Bases;
using IczpNet.Organization.Departments;
using IczpNet.Organization.EmployeePositions;
using IczpNet.Organization.EmployeeStates;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IczpNet.Organization.Employees
{
    public class Employee: BaseEntity<Guid>
    {
        public virtual Guid? DepartmentId { get; set; }

        public virtual Guid? EmployeeStateId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public virtual Department Department { get; set; }

        [ForeignKey(nameof(EmployeeStateId))]
        public virtual EmployeeState EmployeeState { get; set; }

        public virtual IEnumerable<EmployeePosition> PositionList { get; set; }
    }
}
