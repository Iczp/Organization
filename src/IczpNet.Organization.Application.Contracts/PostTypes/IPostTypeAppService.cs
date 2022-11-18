using IczpNet.Organization.PostTypes.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.PostTypes
{
    public interface IPostTypeAppService :
        ICrudAppService<
            PostTypeDetailDto,
            PostTypeDto,
            Guid,
            PostTypeGetListInput,
            PostTypeCreateInput,
            PostTypeUpdateInput>
    {
    }
}
