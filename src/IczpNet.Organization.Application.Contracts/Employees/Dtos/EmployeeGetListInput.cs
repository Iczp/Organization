using IczpNet.AbpCommons.DataFilters;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.Employees.Dtos;

public class EmployeeGetListInput : EmployeeFilterInput, IPagedAndSortedResultRequest, IKeyword
{
    [DefaultValue(0)]
    public virtual int SkipCount { get; set; }

    [DefaultValue(10)]
    public virtual int MaxResultCount { get; set; }

    [DefaultValue("")]
    public virtual string Sorting { get; set; }
}
