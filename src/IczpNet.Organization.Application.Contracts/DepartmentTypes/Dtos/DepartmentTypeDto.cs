using System;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.DepartmentTypes.Dtos
{
    public class DepartmentTypeDto : DepartmentTypeInfo, IEntityDto<Guid>
    {
        public virtual string Description { get; set; }
    }
}
