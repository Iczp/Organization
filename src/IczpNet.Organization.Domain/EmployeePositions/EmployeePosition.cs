using IczpNet.Organization.Bases;
using IczpNet.Organization.Employees;
using IczpNet.Organization.Positions;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace IczpNet.Organization.EmployeePositions
{
    public class EmployeePosition : BaseEntity
    {
        public virtual Guid EmployeeId { get; set; }
        public virtual Guid PositionId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee Employee { get; set; }

        [ForeignKey(nameof(PositionId))]
        public virtual Position Position { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { EmployeeId, PositionId };
        }
    }
}
