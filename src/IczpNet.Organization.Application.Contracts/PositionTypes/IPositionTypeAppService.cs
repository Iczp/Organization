using IczpNet.Organization.PositionTypes.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.PositionTypes
{
    public interface IPositionTypeAppService :
        ICrudAppService<
            PositionTypeDetailDto,
            PositionTypeDto,
            Guid,
            PositionTypeGetListInput,
            PositionTypeCreateInput,
            PositionTypeUpdateInput>
    {
    }
}
