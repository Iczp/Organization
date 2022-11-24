using IczpNet.AbpTrees;
using IczpNet.Organization.Companys.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.Companys
{
    public interface ICompanyAppService :
        ICrudAppService<
            CompanyDetailDto,
            CompanyDto,
            Guid,
            CompanyGetListInput,
            CompanyCreateInput,
            CompanyUpdateInput>
        ,
        ITreeAppService<Guid, CompanyInfo>
    {
    }
}
