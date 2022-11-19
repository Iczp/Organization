using IczpNet.Organization.BaseDtos;
using System;

namespace IczpNet.Organization.PostGrades.Dtos
{
    public class PostGradeDto : BaseDto
    {
        public virtual Guid PostRankId { get; set; }

        public virtual Guid? PostLevelId { get; set; }
    }
}
