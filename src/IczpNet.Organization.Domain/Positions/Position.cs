using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.DepartmentPositions;
using IczpNet.Organization.EmployeePositions;
using IczpNet.Organization.PositionFunctionals;
using IczpNet.Organization.PositionTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.MultiTenancy;

namespace IczpNet.Organization.Positions
{
    public class Position : BaseTreeEntity<Position, Guid>, IMultiTenant
    {
        public virtual bool IsSecretary { get; set; }

        public virtual Guid? PositionTypeId { get; private set; }

        //public virtual Guid? PostGradeId { get; private set; }

        //[ForeignKey(nameof(PostGradeId))]
        //public virtual PostGrade PostGrade { get; private set; }

        [ForeignKey(nameof(PositionTypeId))]
        public virtual PositionType PositionType { get; private set; }

        public virtual IEnumerable<EmployeePosition> EmployeeList { get; set; } = new List<EmployeePosition>();

        public virtual IEnumerable<PositionFunctional> FunctionalList { get; set; } = new List<PositionFunctional>();

        public virtual IEnumerable<DepartmentPosition> PositionlList { get; set; } = new List<DepartmentPosition>();
    }
}
