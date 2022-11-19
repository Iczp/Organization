using System;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.Positions.Dtos
{
    public class PositionDto : PositionInfo, IEntityDto<Guid>
    {
        public virtual string Description { get; set; }
    }
}
