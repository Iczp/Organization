using IczpNet.Organization.Bases;
using IczpNet.Organization.Departments;
using IczpNet.Organization.EmployeePositions;
using IczpNet.Organization.EmployeeStates;
using IczpNet.Organization.EmployeeTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IczpNet.Organization.Employees
{
    public class Employee: BaseEntity<Guid>
    {
        public virtual Guid? DepartmentId { get; private set; }

        public virtual Guid? EmployeeStateId { get; private set; }

        public virtual Guid? EmployeeTypeId { get; private set; }

        [ForeignKey(nameof(DepartmentId))]
        public virtual Department Department { get; private set; }

        [ForeignKey(nameof(EmployeeStateId))]
        public virtual EmployeeState EmployeeState { get; private set; }

        [ForeignKey(nameof(EmployeeTypeId))]
        public virtual EmployeeType EmployeeType { get; private set; }

        public virtual IEnumerable<EmployeePosition> PositionList { get; private set; } = new List<EmployeePosition>();
    }
}
