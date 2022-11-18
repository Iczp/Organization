using IczpNet.Organization.BaseDtos;
using System;
using System.ComponentModel;

namespace IczpNet.Organization.PostRanks.Dtos;

public class PostRankGetListInput : BaseGetListInput
{
    [DefaultValue(null)]
    public virtual Guid? PostTypeId { get; set; }

}
