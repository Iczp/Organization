using System;
using System.ComponentModel;

namespace IczpNet.Organization.Companys.Dtos;

public class CompanyGetAllListWithChildsInput 
{
    [DefaultValue(null)]
    public virtual Guid? ParentId { get; set; }

    public virtual bool IsImportAllChilds { get; set; }
}
