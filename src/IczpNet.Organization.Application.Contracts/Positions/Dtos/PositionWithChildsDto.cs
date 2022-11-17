using IczpNet.AbpTrees;

namespace IczpNet.Organization.Positions.Dtos;

/// <summary>
/// PositionWithChildsDto
/// </summary>
public class PositionWithChildsDto : TreeWithChildsInfo<PositionWithChildsDto>
{
    public virtual string Code { get; set; }
    public virtual int ChildsCount { get; set; }
}
