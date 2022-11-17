using IczpNet.Organization.Bases;
using IczpNet.Organization.EmployeeStates;
using IczpNet.Organization.EmployeeStates.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class EmployeeStateAppService
        : CrudOrganizationAppService<
            EmployeeState,
            EmployeeStateDetailDto,
            EmployeeStateDto,
            Guid,
            EmployeeStateGetListInput,
            EmployeeStateCreateInput,
            EmployeeStateUpdateInput>,
        IEmployeeStateAppService
    {
        public EmployeeStateAppService(IRepository<EmployeeState, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<EmployeeState>> CreateFilteredQueryAsync(EmployeeStateGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                .WhereIf(!input.Keyword.IsNullOrEmpty(), x => x.Name.Contains(input.Keyword) || x.Code.Contains(input.Keyword));
        }
    }
}
