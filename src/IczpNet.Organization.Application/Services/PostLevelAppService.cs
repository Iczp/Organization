using IczpNet.Organization.Bases;
using IczpNet.Organization.PostLevels;
using IczpNet.Organization.PostLevels.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class PostLevelAppService
        : CrudOrganizationAppService<
            PostLevel,
            PostLevelDetailDto,
            PostLevelDto,
            Guid,
            PostLevelGetListInput,
            PostLevelCreateInput,
            PostLevelUpdateInput>,
        IPostLevelAppService
    {
        public PostLevelAppService(IRepository<PostLevel, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<PostLevel>> CreateFilteredQueryAsync(PostLevelGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                .WhereIf(!input.Keyword.IsNullOrEmpty(), x => x.Name.Contains(input.Keyword) || x.Code.Contains(input.Keyword));
        }
    }
}
