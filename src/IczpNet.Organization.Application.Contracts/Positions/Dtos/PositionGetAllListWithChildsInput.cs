using System;
using System.ComponentModel;

namespace IczpNet.Organization.Positions.Dtos;

public class PositionGetAllListWithChildsInput 
{

    /// <summary>
    /// 上级部门
    /// </summary>
    [DefaultValue(null)]
    public virtual Guid? ParentId { get; set; }
    /// <summary>
    /// 是否包含所有子集
    /// </summary>
    public virtual bool IsImportAllChilds { get; set; }
}
