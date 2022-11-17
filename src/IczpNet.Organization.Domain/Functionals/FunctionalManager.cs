using IczpNet.AbpTrees;
using System;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Functionals
{
    public class FunctionalManager : TreeManager<Functional>, IFunctionalManager
    {
        public FunctionalManager(IRepository<Functional, Guid> repository) : base(repository)
        {
        }
    }
}
