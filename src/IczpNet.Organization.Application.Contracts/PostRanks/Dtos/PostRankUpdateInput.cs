using IczpNet.Organization.BaseDtos;
using System;

namespace IczpNet.Organization.PostRanks.Dtos;

public class PostRankUpdateInput : BaseInput
{
    public virtual Guid PostTypeId { get; set; }
}
