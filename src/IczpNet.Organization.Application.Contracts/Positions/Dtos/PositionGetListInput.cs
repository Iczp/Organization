using IczpNet.Organization.BaseDtos;
using System;
using System.ComponentModel;

namespace IczpNet.Organization.Positions.Dtos;

public class PositionGetListInput : BaseTreeGetListInput
{

    [DefaultValue(null)]
    public virtual Guid? PositionTypeId { get; set; }

}
