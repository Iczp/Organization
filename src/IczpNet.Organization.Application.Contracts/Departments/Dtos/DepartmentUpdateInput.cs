using IczpNet.AbpTrees.Dtos;
using System;

namespace IczpNet.Organization.Departments.Dtos;

/// <summary>
/// DepartmentUpdateInput
/// </summary>
public class DepartmentUpdateInput : ITreeInput
{

    /// <summary>
    /// 上级部门
    /// </summary>
    public virtual Guid? ParentId { get; set; }
    /// <summary>
    /// 名称
    /// </summary>
    public virtual string Name { get; set; }

    public virtual Guid? DepartmentTypeId { get; set; }

    public virtual string Code { get; set; }
    /// <summary>
    /// 排序（越大越前面） DESC
    /// </summary>
    public virtual long Sorting { get; set; }
    /// <summary>
    /// 说明
    /// </summary>
    public virtual string Description { get; set; }

}
