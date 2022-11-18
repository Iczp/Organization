using IczpNet.Organization.BaseDtos;
using System;

namespace IczpNet.Organization.Companys.Dtos;

public class CompanyWithChildsDto : BaseTreeWithChildsDto<CompanyWithChildsDto>
{
    public virtual Guid? CompanyTypeId { get; set; }
}
