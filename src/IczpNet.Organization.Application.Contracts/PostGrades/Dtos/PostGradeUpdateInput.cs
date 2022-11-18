using IczpNet.AbpCommons.DataFilters;
using IczpNet.Organization.BaseDtos;
using System;

namespace IczpNet.Organization.PostGrades.Dtos;

public class PostGradeUpdateInput : BaseInput, IName
{
    public virtual Guid PostRankId { get; set; }

    public virtual long Value { get; set; }
}
