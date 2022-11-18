using IczpNet.Organization.BaseInfos;
using System;

namespace IczpNet.Organization.Positions
{
    public class PositionInfo : BaseTreeInfo
    {
        public virtual Guid? PositionTypeId { get; set; }
    }
}
