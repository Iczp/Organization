using IczpNet.AbpTrees;

namespace IczpNet.Organization.Companys.Dtos;

/// <summary>
/// CompanyWithChildsDto
/// </summary>
public class CompanyWithChildsDto : TreeWithChildsInfo<CompanyWithChildsDto>
{
    public virtual string Code { get; set; }
    public virtual int ChildsCount { get; set; }
}
