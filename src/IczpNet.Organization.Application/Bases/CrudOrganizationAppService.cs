using IczpNet.AbpCommons;
using IczpNet.Organization.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

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

    protected override Task SetCreateEntityAsync(TEntity entity, TCreateInput input)
    {
        return Task.CompletedTask;
    }


    protected override Task SetUpdateEntityAsync(TEntity entity, TUpdateInput input)
    {
        return Task.CompletedTask;
    }

}
