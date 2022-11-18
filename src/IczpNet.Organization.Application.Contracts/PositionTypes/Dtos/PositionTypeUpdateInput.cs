namespace IczpNet.Organization.PositionTypes.Dtos;

/// <summary>
/// DepartmentUpdateInput
/// </summary>
public class PositionTypeUpdateInput
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
    public virtual bool IsActive { get; set; }
}
