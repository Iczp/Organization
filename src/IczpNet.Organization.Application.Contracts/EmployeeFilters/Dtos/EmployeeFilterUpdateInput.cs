using IczpNet.Organization.BaseDtos;
using IczpNet.Organization.Employees;
using JetBrains.Annotations;

namespace IczpNet.Organization.EmployeeFilters.Dtos;

public class EmployeeFilterUpdateInput : BaseInput
{
    [NotNull]
    public virtual EmployeeFilterParameter FilterParameter { get; set; }

}
