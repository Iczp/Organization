namespace IczpNet.Organization.PostTypes.Dtos;

public class PostTypeUpdateInput
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
    public virtual bool IsActive { get; set; }
}
