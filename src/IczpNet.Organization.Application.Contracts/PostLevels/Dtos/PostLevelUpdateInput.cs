using IczpNet.AbpCommons.DataFilters;

namespace IczpNet.Organization.PostLevels.Dtos;

public class PostLevelUpdateInput : IName
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
    public virtual bool IsActive { get; set; }
    public virtual long Value { get; set; }
}
