using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.Departments;
using IczpNet.Organization.Positions;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IczpNet.Organization.DepartmentPositions
{
    public class DepartmentPosition : BaseEntity
    {
        public virtual Guid PositionId { get; set; }
        public virtual Guid DepartmentId { get; set; }

        [ForeignKey(nameof(PositionId))]
        public virtual Position Position { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public virtual Department Department { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { PositionId, DepartmentId };
        }
    }
}
