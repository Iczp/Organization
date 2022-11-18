﻿using IczpNet.AbpTrees;
using System;

namespace IczpNet.Organization.Departments
{
    public class DepartmentInfo : TreeInfo
    {
        public virtual Guid? DepartmentTypeId { get; set; }

        public virtual string Code { get; set; }

        public virtual bool IsStatic { get; set; }

        public virtual bool IsActive { get; set; }
    }
}
