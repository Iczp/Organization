using IczpNet.AbpCommons;
using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.EmployeeFilters;
using IczpNet.Organization.EmployeeFilters.Dtos;
using IczpNet.Organization.Employees;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Json;

namespace IczpNet.Organization.Services
{
    public class EmployeeFilterAppService
        : CrudOrganizationAppService<
            EmployeeFilter,
            EmployeeFilterDetailDto,
            EmployeeFilterDto,
            Guid,
            EmployeeFilterGetListInput,
            EmployeeFilterCreateInput,
            EmployeeFilterUpdateInput>,
        IEmployeeFilterAppService
    {

        protected IJsonSerializer JsonSerializer { get; }
        protected IEmployeeManager EmployeeManager { get; }
        public EmployeeFilterAppService(
            IRepository<EmployeeFilter, Guid> repository,
            IJsonSerializer jsonSerializer,
            IEmployeeManager employeeManager) : base(repository)
        {
            JsonSerializer = jsonSerializer;
            EmployeeManager = employeeManager;
        }

        protected override async Task<IQueryable<EmployeeFilter>> CreateFilteredQueryAsync(EmployeeFilterGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                .WhereIf(!input.Keyword.IsNullOrEmpty(), x => x.Name.Contains(input.Keyword) || x.Code.Contains(input.Keyword));
        }

        protected override async Task<EmployeeFilter> MapToEntityAsync(EmployeeFilterCreateInput createInput)
        {
            Assert.NotNull(createInput.FilterParameter, $"[{nameof(createInput.FilterParameter)}] cannot be null.");

            var entity = await base.MapToEntityAsync(createInput);

            entity.SetFilterParameter(createInput.FilterParameter, JsonSerializer);

            var totalCount = await EmployeeManager.GetFilteredCountAsync(createInput.FilterParameter);

            entity.SetFilteredResult(totalCount);

            return entity;
        }

        [HttpPost]
        public override async Task<EmployeeFilterDetailDto> CreateAsync(EmployeeFilterCreateInput input)
        {
            Assert.If(await Repository.AnyAsync(x => x.Name == input.Name), $"Name[:{input.Name}] already exists.");

            Assert.If(input.Code.IsNullOrWhiteSpace() && await Repository.AnyAsync(x => x.Code == input.Code), $"Code[:{input.Code}] already exists.");

            return await base.CreateAsync(input);
        }

        [HttpPost]
        public override async Task<EmployeeFilterDetailDto> UpdateAsync(Guid id, EmployeeFilterUpdateInput input)
        {
            Assert.If(await Repository.AnyAsync(x => x.Id != id && x.Name == input.Name), $"Name[:{input.Name}] already exists.");

            Assert.If(input.Code.IsNullOrWhiteSpace() && await Repository.AnyAsync(x => x.Id != id && x.Code == input.Code), $"Code[:{input.Code}] already exists.");

            return await base.UpdateAsync(id, input);
        }

        protected override async Task MapToEntityAsync(EmployeeFilterUpdateInput updateInput, EmployeeFilter entity)
        {
            Assert.NotNull(updateInput.FilterParameter, $"[{nameof(updateInput.FilterParameter)}] cannot be null.");

            await base.MapToEntityAsync(updateInput, entity);

            entity.SetFilterParameter(updateInput.FilterParameter, JsonSerializer);

            var totalCount = await EmployeeManager.GetFilteredCountAsync(updateInput.FilterParameter);

            entity.SetFilteredResult(totalCount);
        }
    }
}
