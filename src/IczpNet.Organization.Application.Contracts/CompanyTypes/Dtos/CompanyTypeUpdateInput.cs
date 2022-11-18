using IczpNet.AbpCommons.DataFilters;

namespace IczpNet.Organization.CompanyTypes.Dtos;

/// <summary>
/// CompanyUpdateInput
/// </summary>
public class CompanyTypeUpdateInput : IName
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
    public virtual bool IsActive { get; set; }
}
