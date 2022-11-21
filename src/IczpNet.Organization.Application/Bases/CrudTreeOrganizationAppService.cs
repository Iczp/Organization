using IczpNet.AbpTrees;
using IczpNet.AbpTrees.Dtos;
using IczpNet.Organization.BaseEntitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
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
        where TEntity : BaseTreeEntity<TEntity>, ITreeEntity
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

        [HttpPost]
        public override async Task RepairDataAsync()
        {

            var list = await Repository.GetListAsync();

            foreach (var entity in list)
            {
                SetEntity(entity);

                //await TreeManager.UpdateAsync(entity);
            }

            //return base.RepairDataAsync();
        }

        protected virtual void SetEntity(TEntity entity)
        {
            Logger.LogInformation("5555:" + entity.Name);

            entity.SetName(entity.Name);

            Logger.LogInformation("pinyin:" + entity.Name_Py);
        }
    }
}
