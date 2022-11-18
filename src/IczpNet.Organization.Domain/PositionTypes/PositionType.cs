using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.Positions;
using System;
using System.Collections.Generic;

namespace IczpNet.Organization.PositionTypes
{
    public class PositionType : BaseEntity<Guid>
    {
        public virtual bool IsStatic { get; set; }
        public virtual IEnumerable<Position> PositionList { get; set; }
    }
}
