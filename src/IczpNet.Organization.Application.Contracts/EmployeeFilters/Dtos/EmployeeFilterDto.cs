using IczpNet.Organization.BaseDtos;
using System;

namespace IczpNet.Organization.EmployeeFilters.Dtos
{
    public class EmployeeFilterDto : BaseDto
    {
        public virtual string Description { get; set; }

        public virtual string ResultMessage { get; set; }

        public virtual int? TotalCount { get; set; }

        public virtual DateTime? LastRunTime { get; set; }
    }
}
