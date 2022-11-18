using IczpNet.AbpCommons.DataFilters;

namespace IczpNet.Organization.PostGrades.Dtos;

public class PostGradeUpdateInput : IName
{
    public virtual string Name { get; set; }
    public virtual string Code { get; set; }
    public virtual bool IsActive { get; set; }
}
