using IczpNet.AbpTrees;

namespace IczpNet.Organization.Functionals.Dtos;

public class FunctionalWithChildsDto : TreeWithChildsInfo<FunctionalWithChildsDto>
{
    public virtual string Code { get; set; }

    public virtual int ChildsCount { get; set; }
}
