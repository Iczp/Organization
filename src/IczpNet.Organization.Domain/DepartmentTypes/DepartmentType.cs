using IczpNet.Organization.Departments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace IczpNet.Organization.DepartmentTypes
{
    public class DepartmentType : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public virtual Guid? TenantId { get; set; }
        [MaxLength(64)]
        public virtual string Name { get; set; }
        [MaxLength(64)]
        public virtual string Code { get; set; }
        public virtual bool IsStatic { get; set; }
        public virtual IEnumerable<Department> DepartmentList { get; set; }
    }
}
