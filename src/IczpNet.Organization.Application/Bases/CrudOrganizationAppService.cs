using IczpNet.AbpCommons.DataFilters;
using IczpNet.Organization.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.MultiTenancy;

namespace IczpNet.Organization.Bases;

public abstract class CrudOrganizationAppService<
    TEntity,
    TGetOutputDto,
    TGetListOutputDto,
    TKey,
    TGetListInput,
    TCreateInput,
    TUpdateInput>
    :
    CrudAppService<
        TEntity,
        TGetOutputDto,
        TGetListOutputDto,
        TKey,
        TGetListInput,
        TCreateInput,
        TUpdateInput>
    ,
    ICrudOrganizationAppService<
        TGetOutputDto,
        TGetListOutputDto,
        TKey,
        TGetListInput,
        TCreateInput,
        TUpdateInput>

    where TEntity : class, IEntity<TKey>
    where TGetOutputDto : IEntityDto<TKey>
    where TGetListOutputDto : IEntityDto<TKey>
{
    protected CrudOrganizationAppService(IRepository<TEntity, TKey> repository) : base(repository)
    {
        LocalizationResource = typeof(OrganizationResource);
        ObjectMapperContext = typeof(OrganizationApplicationModule);
    }

    [HttpGet]
    public override Task<TGetOutputDto> GetAsync(TKey id)
    {
        return base.GetAsync(id);
    }

    [HttpGet]
    public virtual async Task<List<TGetOutputDto>> GetManyAsync(List<TKey> idList)
    {
        var list = new List<TGetOutputDto>();

        foreach (var id in idList)
        {
            list.Add(await base.GetAsync(id));
        }
        return list;
    }

    [HttpGet]
    public override Task<PagedResultDto<TGetListOutputDto>> GetListAsync(TGetListInput input)
    {
        return base.GetListAsync(input);
    }

    [HttpPost]
    public override async Task<TGetOutputDto> CreateAsync(TCreateInput input)
    {
        await CheckCreatePolicyAsync();

        var entity = await MapToEntityAsync(input);

        await SetCreateEntityAsync(entity, input);

        TryToSetTenantId(entity);

        await Repository.InsertAsync(entity, autoSave: true);

        return await MapToGetOutputDtoAsync(entity);
    }

    protected virtual Task SetCreateEntityAsync(TEntity entity, TCreateInput input)
    {
        return Task.CompletedTask;
    }



    [HttpPost]
    public override async Task<TGetOutputDto> UpdateAsync(TKey id, TUpdateInput input)
    {
        await CheckUpdatePolicyAsync();

        var entity = await GetEntityByIdAsync(id);
        //TODO: Check if input has id different than given id and normalize if it's default value, throw ex otherwise
        await MapToEntityAsync(input, entity);

        await SetUpdateEntityAsync(entity, input);

        await Repository.UpdateAsync(entity, autoSave: true);

        return await MapToGetOutputDtoAsync(entity);
    }

    protected virtual Task SetUpdateEntityAsync(TEntity entity, TUpdateInput input)
    {
        return Task.CompletedTask;
    }

    [HttpPost]
    public override Task DeleteAsync(TKey id)
    {
        return base.DeleteAsync(id);
    }

    [HttpPost]
    public virtual async Task DeleteManyAsync(List<TKey> idList)
    {
        foreach (var id in idList)
        {
            await base.DeleteAsync(id);
        }
    }
}
