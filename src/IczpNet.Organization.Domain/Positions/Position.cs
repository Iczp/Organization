using IczpNet.AbpTrees;
using IczpNet.Organization.EmployeePositions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.MultiTenancy;

namespace IczpNet.Organization.Positions
{
    public class Position : TreeEntity<Position>, IMultiTenant
    {
        public virtual Guid? TenantId { get; set; }

        [MaxLength(64)]
        public virtual string Code { get; set; }

        public virtual bool IsSecretary { get; set; }

        public virtual IEnumerable<EmployeePosition> EmployeeList { get; set; }
    }
}
