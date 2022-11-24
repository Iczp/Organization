using IczpNet.AbpTrees;
using System;

namespace IczpNet.Organization.Positions
{
    public interface IPositionManager : ITreeManager<Position, Guid>
    {
    }
}
