using IczpNet.Organization.BaseDtos;
using System;

namespace IczpNet.Organization.Companys.Dtos;

public class CompanyWithParentDto : BaseTreeWithParentDto<CompanyWithParentDto>
{
    public virtual Guid? CompanyTypeId { get; set; }
}
