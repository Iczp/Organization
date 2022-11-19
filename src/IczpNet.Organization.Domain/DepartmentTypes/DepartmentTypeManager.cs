using IczpNet.AbpTrees;
using IczpNet.Organization.DepartmentTypes;
using System;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Departments
{
    public class DepartmentTypeManager : TreeManager<DepartmentType>, IDepartmentTypeManager
    {
        public DepartmentTypeManager(IRepository<DepartmentType, Guid> repository) : base(repository)
        {
        }
    }
}
