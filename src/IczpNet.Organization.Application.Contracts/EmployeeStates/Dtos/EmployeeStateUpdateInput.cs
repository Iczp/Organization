namespace IczpNet.Organization.EmployeeStates.Dtos;

/// <summary>
/// DepartmentUpdateInput
/// </summary>
public class EmployeeStateUpdateInput
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
    public virtual bool IsStatic { get; set; }
}
