using IczpNet.Organization.Bases;
using IczpNet.Organization.Departments;
using IczpNet.Organization.EmployeePositions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IczpNet.Organization.Employees
{
    public class Employee: BaseEntity
    {
        public virtual Guid? DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public virtual Department Department { get; set; }

        public virtual IEnumerable<EmployeePosition> PositionList { get; set; }
    }
}
