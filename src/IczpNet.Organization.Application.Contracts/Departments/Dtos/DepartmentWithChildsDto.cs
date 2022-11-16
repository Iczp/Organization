using IczpNet.AbpTrees;

namespace IczpNet.Organization.Departments.Dtos;

/// <summary>
/// DepartmentWithChildsDto
/// </summary>
public class DepartmentWithChildsDto : TreeWithChildsInfo<DepartmentWithChildsDto>
{
    public virtual string Code { get; set; }
    public virtual int ChildsCount { get; set; }
}
