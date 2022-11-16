namespace IczpNet.Organization.DepartmentTypes.Dtos;

/// <summary>
/// DepartmentUpdateInput
/// </summary>
public class DepartmentTypeUpdateInput
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
    public virtual bool IsStatic { get; set; }
}
