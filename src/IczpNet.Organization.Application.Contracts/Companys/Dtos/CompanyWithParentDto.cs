using IczpNet.AbpTrees;

namespace IczpNet.Organization.Companys.Dtos;


public class CompanyWithParentDto : TreeWithParentInfo<CompanyWithParentDto>
{
    public virtual string Code { get; set; }

    public virtual long Sorting { get; set; }

    public virtual string Description { get; set; }
}
