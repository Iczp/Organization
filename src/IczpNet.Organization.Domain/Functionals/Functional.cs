﻿using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.DepartmentFunctionals;
using IczpNet.Organization.PositionFunctionals;
using System;
using System.Collections.Generic;
using Volo.Abp.MultiTenancy;

namespace IczpNet.Organization.Functionals
{
    public class Functional : BaseTreeEntity<Functional, Guid>, IMultiTenant
    {
        public virtual IEnumerable<PositionFunctional> PositionList { get; set; }

        public virtual IEnumerable<DepartmentFunctional> DepartmentList { get; set; }
        
    }
}
