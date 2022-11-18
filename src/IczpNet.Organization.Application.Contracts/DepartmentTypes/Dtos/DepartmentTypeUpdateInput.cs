using IczpNet.AbpCommons.DataFilters;

namespace IczpNet.Organization.DepartmentTypes.Dtos;

public class DepartmentTypeUpdateInput : IName
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
    public virtual bool IsActive { get; set; }
}
