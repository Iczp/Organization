using IczpNet.AbpTrees;
using IczpNet.Organization.Positions;
using IczpNet.Organization.Positions.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class PositionAppService
        : TreeAppService<
            Position,
            PositionDetailDto,
            PositionDto,
            PositionGetListInput,
            PositionCreateInput,
            PositionUpdateInput,
            PositionInfo,
            PositionWithChildsDto,
            PositionWithParentDto>,
        IPositionAppService
    {
        public PositionAppService(IRepository<Position, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<Position>> CreateFilteredQueryAsync(PositionGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                //.WhereIf(input.PositionTypeId.HasValue, x => x.PositionlList == input.PositionTypeId)
                ;
        }
    }
}
