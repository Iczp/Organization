using IczpNet.AbpCommons.DataFilters;
using IczpNet.Organization.BaseDtos;
using System;

namespace IczpNet.Organization.PostRanks.Dtos;

public class PostRankUpdateInput : BaseInput, IName
{
    public virtual Guid PostTypeId { get; set; }
}
