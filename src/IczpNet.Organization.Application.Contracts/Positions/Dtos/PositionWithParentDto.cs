using IczpNet.Organization.BaseDtos;
using System;

namespace IczpNet.Organization.Positions.Dtos;

public class PositionWithParentDto : BaseTreeWithParentDto<PositionWithParentDto>
{
    public virtual Guid? PositionTypeId { get; set; }
}
