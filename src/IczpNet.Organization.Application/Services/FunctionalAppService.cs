using IczpNet.AbpCommons;
using IczpNet.Organization.Bases;
using IczpNet.Organization.Functionals;
using IczpNet.Organization.Functionals.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class FunctionalAppService
        : CrudTreeOrganizationAppService<
            Functional,
            Guid,
            FunctionalDetailDto,
            FunctionalDto,
            FunctionalGetListInput,
            FunctionalCreateInput,
            FunctionalUpdateInput,
            FunctionalInfo>,
        IFunctionalAppService
    {
        public FunctionalAppService(IRepository<Functional, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<Functional>> CreateFilteredQueryAsync(FunctionalGetListInput input)
        {

            Assert.If(!input.IsEnabledParentId && input.ParentId.HasValue, "When [IsEnabledParentId]=false,then [ParentId] != null");

            return (await Repository.GetQueryableAsync())
                .WhereIf(input.Depth.HasValue, (x) => x.Depth == input.Depth)
                .WhereIf(input.IsEnabledParentId, (x) => x.ParentId == input.ParentId)
                .WhereIf(!string.IsNullOrWhiteSpace(input.Keyword), x => x.Name.Contains(input.Keyword) || x.Code.Contains(input.Keyword) || x.Name_Pinyin.Contains(input.Keyword) || x.Name_Py.Contains(input.Keyword));


        }
    }
}
