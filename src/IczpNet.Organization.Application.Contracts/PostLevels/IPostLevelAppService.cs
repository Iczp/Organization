using IczpNet.Organization.PostLevels.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.PostLevels
{
    public interface IPostLevelAppService :
        ICrudAppService<
            PostLevelDetailDto,
            PostLevelDto,
            Guid,
            PostLevelGetListInput,
            PostLevelCreateInput,
            PostLevelUpdateInput>
    {
    }
}
