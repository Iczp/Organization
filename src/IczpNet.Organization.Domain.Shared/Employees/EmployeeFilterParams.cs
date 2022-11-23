using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace IczpNet.Organization.Employees
{
    [Serializable]
    public class EmployeeFilterParameter
    {
        [DefaultValue(false)]
        public virtual bool IsImportChildDepartment { get; set; }

        [DefaultValue(false)]
        public virtual bool IsImportChildPosition { get; set; }

        [DefaultValue(null)]
        public virtual List<Guid> DepartmentIdList { get; set; }

        [DefaultValue(null)]
        public virtual List<Guid> EmployeeStateIdList { get; set; }

        [DefaultValue(null)]
        public virtual List<Guid> EmployeeTypeIdList { get; set; }

        [DefaultValue(null)]
        public virtual List<Guid> PostGradeIdList { get; set; }

        [DefaultValue(null)]
        public virtual List<Guid> PostionIdList { get; set; }

        [DefaultValue(null)]
        public virtual bool? IsActive { get; set; }

        [DefaultValue(null)]
        public virtual bool? IsStatic { get; set; }

        [DefaultValue(null)]
        public virtual string Keyword { get; set; }
    }
}
