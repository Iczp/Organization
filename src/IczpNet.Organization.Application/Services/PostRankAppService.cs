using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.PostRanks;
using IczpNet.Organization.PostRanks.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class PostRankAppService
        : CrudOrganizationAppService<
            PostRank,
            PostRankDetailDto,
            PostRankDto,
            Guid,
            PostRankGetListInput,
            PostRankCreateInput,
            PostRankUpdateInput>,
        IPostRankAppService
    {
        public PostRankAppService(IRepository<PostRank, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<PostRank>> CreateFilteredQueryAsync(PostRankGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                .WhereIf(!input.Keyword.IsNullOrEmpty(), x => x.Name.Contains(input.Keyword) || x.Code.Contains(input.Keyword));
        }
    }
}
