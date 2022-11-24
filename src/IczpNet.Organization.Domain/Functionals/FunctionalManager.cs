using IczpNet.AbpTrees;
using System;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Functionals
{
    public class FunctionalManager : TreeManager<Functional, Guid>, IFunctionalManager
    {
        public FunctionalManager(IRepository<Functional, Guid> repository) : base(repository)
        {
        }
    }
}
