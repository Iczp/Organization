using IczpNet.AbpTrees;
using System;

namespace IczpNet.Organization.Positions
{
    public class PositionInfo : TreeInfo
    {
        public virtual Guid? PositionTypeId { get; set; }

        public virtual string Code { get; set; }

        public virtual bool IsStatic { get; set; }

        public virtual bool IsActive { get; set; }
    }
}
