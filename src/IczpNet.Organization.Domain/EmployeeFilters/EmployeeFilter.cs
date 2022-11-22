using IczpNet.Organization.BaseEntitys;
using System;
using System.ComponentModel.DataAnnotations;

namespace IczpNet.Organization.EmployeeFilters
{
    public class EmployeeFilter : BaseEntity<Guid>
    {
        [MaxLength(1000)]
        public virtual string Input { get; protected set; }

        [MaxLength(300)]
        public virtual string ResultMessage { get; protected set; }

        public virtual int? TotalCount { get; set; }

        public virtual int? ItemCount { get; set; }

        public virtual DateTime? LastRunTime { get; set; }

        public virtual void SetFilterInput(string filterInput)
        {
            Input = filterInput;
        }
    }
}
