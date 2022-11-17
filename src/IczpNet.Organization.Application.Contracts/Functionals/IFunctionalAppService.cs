using IczpNet.AbpTrees;
using IczpNet.Organization.Functionals.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.Functionals
{
    public interface IFunctionalAppService :
        ICrudAppService<
            FunctionalDetailDto,
            FunctionalDto,
            Guid,
            FunctionalGetListInput,
            FunctionalCreateInput,
            FunctionalUpdateInput>
        , ITreeAppService<
            FunctionalInfo,
            FunctionalWithChildsDto,
            FunctionalWithParentDto>
    {
    }
}
