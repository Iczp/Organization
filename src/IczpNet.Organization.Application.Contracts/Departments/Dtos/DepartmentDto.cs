using System;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.Departments.Dtos
{
    public class DepartmentDto : DepartmentInfo, IEntityDto<Guid>
    {
        public virtual string Description { get; set; }
    }
}
