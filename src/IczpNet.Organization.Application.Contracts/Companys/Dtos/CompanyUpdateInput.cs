using IczpNet.AbpTrees.Dtos;
using System;

namespace IczpNet.Organization.Companys.Dtos;

/// <summary>
/// CompanyUpdateInput
/// </summary>
public class CompanyUpdateInput : ITreeInput
{
    public virtual Guid? ParentId { get; set; }

    public virtual Guid? CompanyTypeId { get; set; }

    public virtual string Name { get; set; }

    public virtual string Code { get; set; }

    public virtual long Sorting { get; set; }

    public virtual string Description { get; set; }

}
