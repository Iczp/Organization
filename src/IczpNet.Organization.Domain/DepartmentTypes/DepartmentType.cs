﻿using IczpNet.Organization.Bases;
using IczpNet.Organization.Departments;
using System;
using System.Collections.Generic;

namespace IczpNet.Organization.DepartmentTypes
{
    public class DepartmentType : BaseEntity<Guid>
    {
        public virtual bool IsStatic { get; set; }
        public virtual IEnumerable<Department> DepartmentList { get; set; }
    }
}
