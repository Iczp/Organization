using IczpNet.AbpCommons.DataFilters;

namespace IczpNet.Organization.EmployeeStates.Dtos;

public class EmployeeStateUpdateInput : IName
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
    public virtual bool IsStatic { get; set; }
    public virtual bool IsActive { get; set; }

}
