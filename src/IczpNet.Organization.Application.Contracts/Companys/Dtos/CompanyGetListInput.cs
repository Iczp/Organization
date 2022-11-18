using IczpNet.Organization.BaseDtos;
using System;
using System.ComponentModel;

namespace IczpNet.Organization.Companys.Dtos;


public class CompanyGetListInput : BaseTreeGetListInput
{
    [DefaultValue(null)]
    public virtual Guid? CompanyTypeId { get; set; }
}
