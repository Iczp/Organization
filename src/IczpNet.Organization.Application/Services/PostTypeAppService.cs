using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.PostTypes;
using IczpNet.Organization.PostTypes.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class PostTypeAppService
        : CrudOrganizationAppService<
            PostType,
            PostTypeDetailDto,
            PostTypeDto,
            Guid,
            PostTypeGetListInput,
            PostTypeCreateInput,
            PostTypeUpdateInput>,
        IPostTypeAppService
    {
        public PostTypeAppService(IRepository<PostType, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<PostType>> CreateFilteredQueryAsync(PostTypeGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                .WhereIf(!input.Keyword.IsNullOrEmpty(), x => x.Name.Contains(input.Keyword) || x.Code.Contains(input.Keyword));
        }
    }
}
