using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.DepartmentPositions;
using IczpNet.Organization.EmployeePositions;
using IczpNet.Organization.PositionFunctionals;
using IczpNet.Organization.PositionTypes;
using System;
using System.Collections.Generic;
using Volo.Abp.MultiTenancy;

namespace IczpNet.Organization.Positions
{
    public class Position : BaseTreeEntity<Position>, IMultiTenant
    {
        public virtual bool IsSecretary { get; set; }

        public virtual Guid? PositionTypeId { get; private set; }

        public virtual PositionType PositionType { get; private set; }

        public virtual IEnumerable<EmployeePosition> EmployeeList { get; set; }

        public virtual IEnumerable<PositionFunctional> FunctionalList { get; set; }

        public virtual IEnumerable<DepartmentPosition> PositionlList { get; set; }
    }
}
