using IczpNet.Organization.Departments;
using IczpNet.Organization.EmployeePositions;
using IczpNet.Organization.Positions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace IczpNet.Organization.Employees
{
    public class Employee : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public virtual Guid? TenantId { get; set; }

        [MaxLength(64)]
        public virtual string Name { get; set; }

        [MaxLength(64)]
        public virtual string Code { get; set; }

        public virtual Guid? DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public virtual Department Department { get; set; }

        public virtual IEnumerable<EmployeePosition> PositionList { get; set; }
    }
}
