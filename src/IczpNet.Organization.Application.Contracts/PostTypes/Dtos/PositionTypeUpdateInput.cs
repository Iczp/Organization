using IczpNet.AbpCommons.DataFilters;

namespace IczpNet.Organization.PostTypes.Dtos;

public class PostTypeUpdateInput : IName
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
    public virtual bool IsActive { get; set; }
}
