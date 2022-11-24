using IczpNet.AbpTrees;
using System;

namespace IczpNet.Organization.Companys
{
    public interface ICompanyManager : ITreeManager<Company, Guid>
    {
    }
}
