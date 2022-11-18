using IczpNet.Organization.PostGrades.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.PostGrades
{
    public interface IPostGradeAppService :
        ICrudAppService<
            PostGradeDetailDto,
            PostGradeDto,
            Guid,
            PostGradeGetListInput,
            PostGradeCreateInput,
            PostGradeUpdateInput>
    {
    }
}
