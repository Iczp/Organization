using IczpNet.AbpCommons.Extensions;
using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.Employees;
using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Json;

namespace IczpNet.Organization.EmployeeFilters
{
    public class EmployeeFilter : BaseEntity<Guid>
    {
        [MaxLength(1000)]
        public virtual string FilterParameter { get; protected set; }

        [MaxLength(300)]
        public virtual string ResultMessage { get; protected set; }

        public virtual int? TotalCount { get; protected set; }

        public virtual int? ItemCount { get; set; }

        public virtual DateTime? LastRunTime { get; protected set; }

        public virtual EmployeeFilterParameter GetFilterParameter()
        {
            return FilterParameter.ToObject<EmployeeFilterParameter>();
        }

        public void SetFilteredResult(int totalCount)
        {
            TotalCount = totalCount;

            LastRunTime = DateTime.Now;
        }

        public virtual void SetFilterParameter(EmployeeFilterParameter filterParameter, IJsonSerializer jsonSerializer)
        {
            FilterParameter = jsonSerializer.Serialize(filterParameter);
        }
    }
}
