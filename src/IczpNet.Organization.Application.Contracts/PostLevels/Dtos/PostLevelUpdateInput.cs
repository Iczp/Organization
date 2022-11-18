using IczpNet.Organization.BaseDtos;

namespace IczpNet.Organization.PostLevels.Dtos;
public class PostLevelUpdateInput : BaseInput
{
    public virtual long Value { get; set; }
}
