using IczpNet.AbpCommons.DataFilters;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.CompanyTypes.Dtos;

/// <summary>
/// CompanyGetListInput
/// </summary>
public class CompanyTypeGetListInput : PagedAndSortedResultRequestDto, IKeyword
{
    public virtual bool? IsStatic { get; set; }

    public virtual bool? IsActive { get; set; }

    /// <summary>
    /// 关键字(支持拼音)
    /// </summary>
    [DefaultValue(null)]
    public virtual string Keyword { get; set; }
}
