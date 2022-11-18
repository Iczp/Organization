using IczpNet.AbpTrees;

namespace IczpNet.Organization.Functionals.Dtos;

public class FunctionalWithParentDto : TreeWithParentInfo<FunctionalWithParentDto>
{
    public virtual string Code { get; set; }

    public virtual long Sorting { get; set; }

    public virtual string Description { get; set; }
}
