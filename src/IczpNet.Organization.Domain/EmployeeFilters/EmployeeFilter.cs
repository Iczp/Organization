using IczpNet.Organization.BaseEntitys;
using System;
using System.ComponentModel.DataAnnotations;

namespace IczpNet.Organization.EmployeeFilters
{
    public class EmployeeFilter : BaseEntity<Guid>
    {
        [MaxLength(1000)]
        public virtual string Parameter { get; set; }

        public virtual int? ResultCount { get; set; }

        public virtual DateTime? ResultTime { get; set; }

    }
}
