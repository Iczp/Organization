using IczpNet.Organization.Departments;
using IczpNet.Organization.EmployeePositions;
using System.Collections.Generic;
using Volo.Abp.MultiTenancy;

namespace IczpNet.Organization.Positions
{
    public class Position : BaseTreeEntity<Position>, IMultiTenant
    {
        public virtual bool IsSecretary { get; set; }

        public virtual IEnumerable<EmployeePosition> EmployeeList { get; set; }
    }
}
