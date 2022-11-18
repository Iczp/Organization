using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.Functionals;
using IczpNet.Organization.Positions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IczpNet.Organization.PositionFunctionals
{

    public class PositionFunctional : BaseEntity
    {
        public virtual Guid FunctionalId { get; set; }
        public virtual Guid PositionId { get; set; }

        [ForeignKey(nameof(FunctionalId))]
        public virtual Functional Functional { get; set; }

        [ForeignKey(nameof(PositionId))]
        public virtual Position Position { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { FunctionalId, PositionId };
        }
    }
}
