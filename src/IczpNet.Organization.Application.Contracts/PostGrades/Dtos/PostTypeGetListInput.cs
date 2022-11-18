using IczpNet.Organization.BaseDtos;
using System;
using System.ComponentModel;

namespace IczpNet.Organization.PostGrades.Dtos;

public class PostGradeGetListInput : BaseGetListInput
{
    [DefaultValue(null)]
    public virtual Guid? PostRankId { get; set; }
}
