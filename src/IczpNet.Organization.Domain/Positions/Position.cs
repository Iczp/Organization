using IczpNet.Organization.Bases;
using IczpNet.Organization.DepartmentPositions;
using IczpNet.Organization.EmployeePositions;
using IczpNet.Organization.PositionFunctionals;
using System.Collections.Generic;
using Volo.Abp.MultiTenancy;

namespace IczpNet.Organization.Positions
{
    public class Position : BaseTreeEntity<Position>, IMultiTenant
    {
        public virtual bool IsSecretary { get; set; }

        public virtual IEnumerable<EmployeePosition> EmployeeList { get; set; }

        public virtual IEnumerable<PositionFunctional> FunctionalList { get; set; }

        public virtual IEnumerable<DepartmentPosition> PositionlList { get; set; }
    }
}
