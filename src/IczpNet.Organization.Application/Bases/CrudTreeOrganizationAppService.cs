using IczpNet.AbpTrees;
using IczpNet.AbpTrees.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Bases
{
    public abstract class CrudTreeOrganizationAppService<
        TEntity,
        TGetOutputDto,
        TGetListOutputDto,
        TGetListInput,
        TCreateInput,
        TUpdateInput,
        TTreeInfo,
        TTreeWithChildsDto,
        TTreeWithParentDto>
        :
        TreeAppService<
            TEntity,
            TGetOutputDto,
            TGetListOutputDto,
            TGetListInput,
            TCreateInput,
            TUpdateInput,
            TTreeInfo,
            TTreeWithChildsDto,
            TTreeWithParentDto>
        ,
        ITreeAppService<
        TTreeInfo,
        TTreeWithChildsDto,
        TTreeWithParentDto>
        where TEntity : class, ITreeEntity<TEntity>, ITreeEntity
        where TGetOutputDto : IEntityDto<Guid>
        where TGetListOutputDto : IEntityDto<Guid>
        where TGetListInput : ITreeGetListInput
        where TCreateInput : ITreeInput
        where TUpdateInput : ITreeInput
        where TTreeInfo : ITreeInfo
        where TTreeWithChildsDto : ITreeWithChildsInfo<TTreeWithChildsDto>
        where TTreeWithParentDto : ITreeWithParentInfo<TTreeWithParentDto>
    {
        protected CrudTreeOrganizationAppService(IRepository<TEntity, Guid> repository) : base(repository)
        {
        }
    }
}
