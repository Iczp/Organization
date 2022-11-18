using IczpNet.AbpCommons.DataFilters;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.DepartmentTypes.Dtos;

/// <summary>
/// DepartmentGetListInput
/// </summary>
public class DepartmentTypeGetListInput : PagedAndSortedResultRequestDto, IKeyword
{
    public virtual bool? IsStatic { get; set; }

    public virtual bool? IsActive { get; set; }

    /// <summary>
    /// 关键字(支持拼音)
    /// </summary>
    [DefaultValue(null)]
    public virtual string Keyword { get; set; }
}
