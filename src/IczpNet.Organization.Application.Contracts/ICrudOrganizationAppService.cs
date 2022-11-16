using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization
{

    public interface ICrudOrganizationAppService<
        TGetOutputDto,
        TGetListOutputDto,
        TKey,
        TGetListInput,
        TCreateInput,
        TUpdateInput>
        :
        ICrudAppService<
            TGetOutputDto,
            TGetListOutputDto,
            TKey,
            TGetListInput,
            TCreateInput,
            TUpdateInput>
    {
        Task<List<TGetOutputDto>> GetManyAsync(List<TKey> idList);

        Task DeleteManyAsync(List<TKey> idList);
    }

    public interface ICrudCommonAppService<
            TGetOutputDto,
            TGetListOutputDto,
            TKey,
            TGetListInput>
        :
        ICrudAppService<
            TGetOutputDto,
            TGetListOutputDto,
            TKey,
            TGetListInput>
    {

    }
}
