﻿using IczpNet.Organization.Bases;
using IczpNet.Organization.Companys;
using System;
using System.Collections.Generic;

namespace IczpNet.Organization.CompanyTypes
{
    public class CompanyType : BaseEntity<Guid>
    {
        public virtual bool IsStatic { get; set; }

        public virtual IEnumerable<Company> CompanyList { get; set; }
    }
}