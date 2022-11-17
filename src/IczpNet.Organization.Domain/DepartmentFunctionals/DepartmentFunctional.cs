using IczpNet.Organization.Bases;
using IczpNet.Organization.Departments;
using IczpNet.Organization.Functionals;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IczpNet.Organization.DepartmentFunctionals
{
    public class DepartmentFunctional : BaseEntity
    {
        public virtual Guid FunctionalId { get; set; }
        public virtual Guid DepartmentId { get; set; }

        [ForeignKey(nameof(FunctionalId))]
        public virtual Functional Functional { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public virtual Department Department { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { FunctionalId, DepartmentId };
        }
    }
}
