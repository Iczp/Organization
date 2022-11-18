using IczpNet.AbpCommons.DataFilters;

namespace IczpNet.Organization.Employees.Dtos;

/// <summary>
/// EmployeeUpdateInput
/// </summary>
public class EmployeeUpdateInput : IName
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
}
