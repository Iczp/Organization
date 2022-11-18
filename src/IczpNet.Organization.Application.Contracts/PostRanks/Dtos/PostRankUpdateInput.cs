namespace IczpNet.Organization.PostRanks.Dtos;

public class PostRankUpdateInput
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
    public virtual bool IsActive { get; set; }
}
