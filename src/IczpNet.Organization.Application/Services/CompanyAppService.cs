using IczpNet.Organization.Bases;
using IczpNet.Organization.Companys;
using IczpNet.Organization.Companys.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class CompanyAppService
        : CrudTreeOrganizationAppService<
            Company,
            CompanyDetailDto,
            CompanyDto,
            CompanyGetListInput,
            CompanyCreateInput,
            CompanyUpdateInput,
            CompanyInfo,
            CompanyWithChildsDto,
            CompanyWithParentDto>,
        ICompanyAppService
    {
        public CompanyAppService(IRepository<Company, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<Company>> CreateFilteredQueryAsync(CompanyGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                //.WhereIf(input.CompanyTypeId.HasValue, x => x.CompanylList == input.CompanyTypeId)
                ;
        }
    }
}
