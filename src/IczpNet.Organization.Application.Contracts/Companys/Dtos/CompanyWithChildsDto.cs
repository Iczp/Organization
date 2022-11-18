using IczpNet.AbpTrees;

namespace IczpNet.Organization.Companys.Dtos;

public class CompanyWithChildsDto : TreeWithChildsInfo<CompanyWithChildsDto>
{
    public virtual string Code { get; set; }
    public virtual int ChildsCount { get; set; }
}
