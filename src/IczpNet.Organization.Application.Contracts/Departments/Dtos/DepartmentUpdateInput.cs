using IczpNet.Organization.BaseDtos;
using System;

namespace IczpNet.Organization.Departments.Dtos;

public class DepartmentUpdateInput : BaseTreeInputDto
{
    public virtual Guid? DepartmentTypeId { get; set; }

    public virtual string Description { get; set; }

}
