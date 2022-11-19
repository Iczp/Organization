using System;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.Companys.Dtos
{
    public class CompanyDto : CompanyInfo, IEntityDto<Guid>
    {
        public virtual string Description { get; set; }
    }
}
