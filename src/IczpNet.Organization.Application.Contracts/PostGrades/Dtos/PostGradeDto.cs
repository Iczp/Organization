using IczpNet.Organization.BaseDtos;
using System;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.PostGrades.Dtos
{
    public class PostGradeDto : BaseDto
    {
        public virtual Guid PostRankId { get; set; }

    }
}
