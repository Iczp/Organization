using IczpNet.Organization.BaseDtos;
using System;

namespace IczpNet.Organization.Departments.Dtos;

/// <summary>
/// DepartmentWithChildsDto
/// </summary>
public class DepartmentWithChildsDto : BaseTreeWithChildsDto<DepartmentWithChildsDto>
{
    public virtual Guid? DepartmentTypeId { get; set; }

}
