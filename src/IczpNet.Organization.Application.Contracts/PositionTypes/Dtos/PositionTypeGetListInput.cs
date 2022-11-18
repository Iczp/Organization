using IczpNet.AbpCommons.DataFilters;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.PositionTypes.Dtos;

public class PositionTypeGetListInput : PagedAndSortedResultRequestDto, IKeyword
{
    [DefaultValue(null)]
    public virtual bool? IsStatic { get; set; }

    [DefaultValue(null)]
    public virtual bool? IsActive { get; set; }

    /// <summary>
    /// 关键字(支持拼音)
    /// </summary>
    [DefaultValue(null)]
    public virtual string Keyword { get; set; }
}
