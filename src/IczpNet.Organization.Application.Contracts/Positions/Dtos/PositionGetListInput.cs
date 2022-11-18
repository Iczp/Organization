using IczpNet.AbpCommons.DataFilters;
using IczpNet.AbpTrees;
using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.Positions.Dtos;

public class PositionGetListInput : PagedAndSortedResultRequestDto, ITreeGetListInput, IKeyword
{

    [DefaultValue(null)]
    public virtual Guid? PositionTypeId { get; set; }

    [DefaultValue(null)]
    public virtual bool? IsStatic { get; set; }

    [DefaultValue(null)]
    public virtual bool? IsActive { get; set; }

    [DefaultValue(false)]
    public virtual bool IsEnabledParentId { get; set; }

    [DefaultValue(null)]
    public virtual int? Depth { get; set; }

    [DefaultValue(null)]
    public virtual Guid? ParentId { get; set; }

    [DefaultValue(null)]
    public virtual string Keyword { get; set; }
}
