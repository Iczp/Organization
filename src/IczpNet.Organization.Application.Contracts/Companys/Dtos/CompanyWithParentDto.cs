using IczpNet.AbpTrees;

namespace IczpNet.Organization.Companys.Dtos;

/// <summary>
/// CompanyWithParentDto
/// </summary>
public class CompanyWithParentDto : TreeWithParentInfo<CompanyWithParentDto>
{
    public virtual string Code { get; set; }
    /// <summary>
    /// 排序（越大越前面） DESC
    /// </summary>
    public virtual long Sorting { get; set; }
    /// <summary>
    /// 说明
    /// </summary>
    public virtual string Description { get; set; }
}
