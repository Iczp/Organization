using IczpNet.Organization.BaseInfos;
using System;

namespace IczpNet.Organization.Companys
{
    public class CompanyInfo : BaseTreeInfo
    {
        public virtual Guid? CompanyTypeId { get; set; }
    }
}
