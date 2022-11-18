using IczpNet.AbpCommons.DataFilters;

namespace IczpNet.Organization.PositionTypes.Dtos;

public class PositionTypeUpdateInput : IName
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
    public virtual bool IsActive { get; set; }
}
