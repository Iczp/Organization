using IczpNet.Organization.BaseDtos;
using System;

namespace IczpNet.Organization.Departments.Dtos;

public class DepartmentWithParentDto : BaseTreeWithParentDto<DepartmentWithParentDto>
{
    public virtual Guid? DepartmentTypeId { get; set; }
}
