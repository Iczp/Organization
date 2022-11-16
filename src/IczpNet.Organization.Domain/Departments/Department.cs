using IczpNet.AbpTrees;
using IczpNet.Organization.DepartmentTypes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.MultiTenancy;

namespace IczpNet.Organization.Departments
{
    public class Department : TreeEntity<Department>, IMultiTenant
    {
        public virtual Guid? TenantId { get; set; }

        [MaxLength(64)]
        public virtual string Code { get; set; }

        public virtual Guid? DepartmentTypeId { get; set; }

        [ForeignKey(nameof(DepartmentTypeId))]
        public virtual DepartmentType DepartmentType { get; set; }
    }
}
