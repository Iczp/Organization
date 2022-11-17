using IczpNet.AbpCommons.DataFilters;
using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.EmployeeStates.Dtos;

/// <summary>
/// DepartmentGetListInput
/// </summary>
public class EmployeeStateGetListInput : PagedAndSortedResultRequestDto, IKeyword
{
    public virtual bool IsStatic { get; set; }
    /// <summary>
    /// 关键字(支持拼音)
    /// </summary>
    [DefaultValue(null)]
    public virtual string Keyword { get; set; }
}
