using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.Departments;
using System.Collections.Generic;

namespace IczpNet.Organization.DepartmentTypes
{
    public class DepartmentType : BaseTreeEntity<DepartmentType>
    {
        public virtual IEnumerable<Department> DepartmentList { get; set; }
    }
}
