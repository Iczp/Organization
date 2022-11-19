using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.Companys;
using System;
using System.Collections.Generic;

namespace IczpNet.Organization.CompanyTypes
{
    public class CompanyType : BaseEntity<Guid>
    {
        public virtual IEnumerable<Company> CompanyList { get; set; }
    }
}
