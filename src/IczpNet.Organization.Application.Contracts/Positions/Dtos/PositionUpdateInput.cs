using IczpNet.Organization.BaseDtos;
using System;
using System.ComponentModel;

namespace IczpNet.Organization.Positions.Dtos;

public class PositionUpdateInput : BaseTreeInputDto
{
    [DefaultValue(null)]
    public virtual Guid? PositionTypeId { get; set; }

    [DefaultValue(null)]
    public virtual Guid? PostGradeId { get; set; }

    public virtual string Description { get; set; }
}
