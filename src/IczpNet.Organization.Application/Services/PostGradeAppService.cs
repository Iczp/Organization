using IczpNet.Organization.Bases;
using IczpNet.Organization.PostGrades;
using IczpNet.Organization.PostGrades.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class PostGradeAppService
        : CrudOrganizationAppService<
            PostGrade,
            PostGradeDetailDto,
            PostGradeDto,
            Guid,
            PostGradeGetListInput,
            PostGradeCreateInput,
            PostGradeUpdateInput>,
        IPostGradeAppService
    {
        public PostGradeAppService(IRepository<PostGrade, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<PostGrade>> CreateFilteredQueryAsync(PostGradeGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                .WhereIf(!input.Keyword.IsNullOrEmpty(), x => x.Name.Contains(input.Keyword) || x.Code.Contains(input.Keyword));
        }
    }
}
