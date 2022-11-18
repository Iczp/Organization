using IczpNet.AbpTrees;
using System;

namespace IczpNet.Organization.Companys
{
    public class CompanyInfo : TreeInfo
    {
        public virtual Guid? CompanyTypeId { get; set; }

        public virtual string Code { get; set; }

        public virtual bool IsStatic { get; set; }

        public virtual bool IsActive { get; set; }
    }
}
