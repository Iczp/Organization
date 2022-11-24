using IczpNet.AbpTrees;
using System;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Companys
{
    public class CompanyManager : TreeManager<Company, Guid>, ICompanyManager
    {
        public CompanyManager(IRepository<Company, Guid> repository) : base(repository)
        {
        }
    }
}
