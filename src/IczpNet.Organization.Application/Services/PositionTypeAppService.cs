using IczpNet.Organization.Bases;
using IczpNet.Organization.PositionTypes;
using IczpNet.Organization.PositionTypes.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class PositionTypeAppService
        : CrudOrganizationAppService<
            PositionType,
            PositionTypeDetailDto,
            PositionTypeDto,
            Guid,
            PositionTypeGetListInput,
            PositionTypeCreateInput,
            PositionTypeUpdateInput>,
        IPositionTypeAppService
    {
        public PositionTypeAppService(IRepository<PositionType, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<PositionType>> CreateFilteredQueryAsync(PositionTypeGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                .WhereIf(!input.Keyword.IsNullOrEmpty(), x => x.Name.Contains(input.Keyword) || x.Code.Contains(input.Keyword));
        }
    }
}
