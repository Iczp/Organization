using IczpNet.Organization.CompanyTypes.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.CompanyTypes
{
    public interface ICompanyTypeAppService :
        ICrudAppService<
            CompanyTypeDetailDto,
            CompanyTypeDto,
            Guid,
            CompanyTypeGetListInput,
            CompanyTypeCreateInput,
            CompanyTypeUpdateInput>
    {
    }
}
