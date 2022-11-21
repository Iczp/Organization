using IczpNet.Organization.Bases;
using IczpNet.Organization.Functionals;
using IczpNet.Organization.Functionals.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class FunctionalAppService
        : CrudTreeOrganizationAppService<
            Functional,
            FunctionalDetailDto,
            FunctionalDto,
            FunctionalGetListInput,
            FunctionalCreateInput,
            FunctionalUpdateInput,
            FunctionalInfo,
            FunctionalWithChildsDto,
            FunctionalWithParentDto>,
        IFunctionalAppService
    {
        public FunctionalAppService(IRepository<Functional, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<Functional>> CreateFilteredQueryAsync(FunctionalGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                //.WhereIf(input.FunctionalTypeId.HasValue, x => x.FunctionallList == input.FunctionalTypeId)
                ;
        }
    }
}
