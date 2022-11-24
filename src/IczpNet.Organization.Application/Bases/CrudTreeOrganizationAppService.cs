using IczpNet.AbpTrees;
using IczpNet.AbpTrees.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Bases
{
    public abstract class CrudTreeOrganizationAppService<
        TEntity,
        TKey,
        TGetOutputDto,
        TGetListOutputDto,
        TGetListInput,
        TCreateInput,
        TUpdateInput,
        TTreeInfo>
        :
        TreeAppService<
            TEntity,
            TKey,
            TGetOutputDto,
            TGetListOutputDto,
            TGetListInput,
            TCreateInput,
            TUpdateInput,
            TTreeInfo>
        ,
        ITreeAppService<TKey, TTreeInfo>
        where TKey : struct
        where TEntity : class, ITreeEntity<TEntity, TKey>
        where TGetOutputDto : IEntityDto<TKey>
        where TGetListOutputDto : IEntityDto<TKey>
        where TGetListInput : ITreeGetListInput<TKey>
        where TCreateInput : ITreeInput<TKey>
        where TUpdateInput : ITreeInput<TKey>
        where TTreeInfo : ITreeInfo<TKey>
    {
        protected CrudTreeOrganizationAppService(IRepository<TEntity, TKey> repository) : base(repository)
        {
        }

    }
}
