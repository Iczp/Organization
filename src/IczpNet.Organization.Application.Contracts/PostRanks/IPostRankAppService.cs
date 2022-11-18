using IczpNet.Organization.PostRanks.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.PostRanks
{
    public interface IPostRankAppService :
        ICrudAppService<
            PostRankDetailDto,
            PostRankDto,
            Guid,
            PostRankGetListInput,
            PostRankCreateInput,
            PostRankUpdateInput>
    {
    }
}
