using IczpNet.AbpTrees;

namespace IczpNet.Organization.Functionals.Dtos;

/// <summary>
/// FunctionalWithChildsDto
/// </summary>
public class FunctionalWithChildsDto : TreeWithChildsInfo<FunctionalWithChildsDto>
{
    public virtual string Code { get; set; }
    public virtual int ChildsCount { get; set; }
}
