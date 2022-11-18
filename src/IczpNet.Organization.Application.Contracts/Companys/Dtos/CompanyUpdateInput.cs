using IczpNet.AbpTrees.Dtos;
using IczpNet.Organization.BaseDtos;
using System;
using System.ComponentModel;

namespace IczpNet.Organization.Companys.Dtos;


public class CompanyUpdateInput : BaseTreeInputDto
{
    [DefaultValue(null)]
    public virtual Guid? CompanyTypeId { get; set; }

    public virtual string Description { get; set; }

}
