using IczpNet.AbpTrees.Dtos;
using System;

namespace IczpNet.Organization.Functionals.Dtos;

public class FunctionalUpdateInput : ITreeInput
{
    public virtual Guid? ParentId { get; set; }

    public virtual string Name { get; set; }

    public virtual string Code { get; set; }

    public virtual long Sorting { get; set; }

    public virtual string Description { get; set; }

}
