using IczpNet.AbpTrees;
using System;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Positions
{
    public class PositionManager : TreeManager<Position, Guid>, IPositionManager
    {
        public PositionManager(IRepository<Position, Guid> repository) : base(repository)
        {
        }
    }
}
