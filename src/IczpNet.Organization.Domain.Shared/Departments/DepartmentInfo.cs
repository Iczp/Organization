using IczpNet.Organization.BaseInfos;
using System;

namespace IczpNet.Organization.Departments
{
    public class DepartmentInfo : BaseTreeInfo
    {
        public virtual Guid? DepartmentTypeId { get; set; }
    }
}
