using IczpNet.AbpCommons;
using IczpNet.AbpCommons.DataFilters;
using IczpNet.Organization.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.BaseEntitys;

public abstract class CrudOrganizationAppService<
    TEntity,
    TGetOutputDto,
    TGetListOutputDto,
    TKey,
    TGetListInput,
    TCreateInput,
    TUpdateInput>
    :
    CrudCommonAppService<
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

    where TEntity : BaseEntity<TKey>, IEntity<TKey>
    where TGetOutputDto : IEntityDto<TKey>
    where TGetListOutputDto : IEntityDto<TKey>
    where TCreateInput : IName
    where TUpdateInput : IName
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

    protected override Task SetCreateEntityAsync(TEntity entity, TCreateInput input)
    {
        entity.SetName(input.Name);
        return Task.CompletedTask;
    }


    protected override Task SetUpdateEntityAsync(TEntity entity, TUpdateInput input)
    {
        entity.SetName(input.Name);
        return Task.CompletedTask;
    }

}
