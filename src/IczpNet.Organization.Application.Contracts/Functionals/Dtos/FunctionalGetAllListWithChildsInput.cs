using System;
using System.ComponentModel;

namespace IczpNet.Organization.Functionals.Dtos;

public class FunctionalGetAllListWithChildsInput 
{

    [DefaultValue(null)]
    public virtual Guid? ParentId { get; set; }

    public virtual bool IsImportAllChilds { get; set; }
}
