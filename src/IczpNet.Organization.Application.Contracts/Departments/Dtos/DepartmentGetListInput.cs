using IczpNet.Organization.BaseDtos;
using System;
using System.ComponentModel;

namespace IczpNet.Organization.Departments.Dtos;

public class DepartmentGetListInput : BaseTreeGetListInput
{

    [DefaultValue(null)]
    public virtual Guid? DepartmentTypeId { get; set; }

}
