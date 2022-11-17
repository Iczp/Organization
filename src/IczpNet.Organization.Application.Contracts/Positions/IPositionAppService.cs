using IczpNet.AbpTrees;
using IczpNet.Organization.Positions.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.Positions
{
    public interface IPositionAppService :
        ICrudAppService<
            PositionDetailDto,
            PositionDto,
            Guid,
            PositionGetListInput,
            PositionCreateInput,
            PositionUpdateInput>
        , ITreeAppService<
            PositionInfo,
            PositionWithChildsDto,
            PositionWithParentDto>
    {
    }
}
