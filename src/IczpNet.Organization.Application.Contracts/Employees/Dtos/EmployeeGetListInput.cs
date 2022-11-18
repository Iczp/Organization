using IczpNet.AbpCommons.DataFilters;
using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.Employees.Dtos;

public class EmployeeGetListInput : PagedAndSortedResultRequestDto, IKeyword
{
    /// <summary>
    /// 关键字(支持拼音)
    /// </summary>
    [DefaultValue(null)]
    public virtual string Keyword { get; set; }
}
