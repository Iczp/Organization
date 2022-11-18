using IczpNet.Organization.Bases;
using IczpNet.Organization.CompanyTypes;
using IczpNet.Organization.CompanyTypes.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class CompanyTypeAppService
        : CrudOrganizationAppService<
            CompanyType,
            CompanyTypeDetailDto,
            CompanyTypeDto,
            Guid,
            CompanyTypeGetListInput,
            CompanyTypeCreateInput,
            CompanyTypeUpdateInput>,
        ICompanyTypeAppService
    {
        public CompanyTypeAppService(IRepository<CompanyType, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<CompanyType>> CreateFilteredQueryAsync(CompanyTypeGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                .WhereIf(!input.Keyword.IsNullOrEmpty(), x => x.Name.Contains(input.Keyword) || x.Code.Contains(input.Keyword));
        }
    }
}
