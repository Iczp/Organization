using IczpNet.AbpTrees;
using System;

namespace IczpNet.Organization.DepartmentTypes
{
    public interface IDepartmentTypeManager : ITreeManager<DepartmentType, Guid>
    {
    }
}
