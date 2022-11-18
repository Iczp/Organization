using IczpNet.AbpTrees;
using IczpNet.Organization.BaseDtos;
using System;

namespace IczpNet.Organization.Positions.Dtos;

public class PositionWithChildsDto : BaseTreeWithChildsDto<PositionWithChildsDto>
{
    public virtual Guid? DepartmentTypeId { get; set; }
}
