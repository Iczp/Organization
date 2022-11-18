using IczpNet.AbpCommons.DataFilters;

namespace IczpNet.Organization.EmployeeTypes.Dtos;

public class EmployeeTypeUpdateInput : IName
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
    public virtual bool IsActive { get; set; }
}
