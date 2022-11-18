namespace IczpNet.Organization.PostGrades.Dtos;

public class PostGradeUpdateInput
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
    public virtual bool IsActive { get; set; }
}
