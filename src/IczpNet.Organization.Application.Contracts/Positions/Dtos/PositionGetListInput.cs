using IczpNet.AbpCommons.DataFilters;
using IczpNet.AbpTrees;
using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.Positions.Dtos;

public class PositionGetListInput : PagedAndSortedResultRequestDto, ITreeGetListInput, IKeyword
{
    [DefaultValue(false)]
    public virtual bool IsEnabledParentId { get; set; }
    /// <summary>
    /// 层级
    /// </summary>
    [DefaultValue(null)]
    public virtual int? Depth { get; set; }
    /// <summary>
    /// 上级部门
    /// </summary>
    [DefaultValue(null)]
    public virtual Guid? ParentId { get; set; }
    /// <summary>
    /// 关键字(支持拼音)
    /// </summary>
    [DefaultValue(null)]
    public virtual string Keyword { get; set; }
}
