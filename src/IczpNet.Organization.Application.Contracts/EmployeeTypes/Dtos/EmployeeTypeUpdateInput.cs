namespace IczpNet.Organization.EmployeeTypes.Dtos;

/// <summary>
/// DepartmentUpdateInput
/// </summary>
public class EmployeeTypeUpdateInput
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
    public virtual bool IsActive { get; set; }
}
