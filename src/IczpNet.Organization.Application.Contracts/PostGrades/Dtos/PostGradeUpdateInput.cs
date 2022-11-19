using IczpNet.Organization.BaseDtos;
using System;

namespace IczpNet.Organization.PostGrades.Dtos;

public class PostGradeUpdateInput : BaseInput
{
    public virtual Guid PostRankId { get; set; }

    public virtual Guid? PostLevelId { get; set; }

    public virtual long Value { get; set; }
}
