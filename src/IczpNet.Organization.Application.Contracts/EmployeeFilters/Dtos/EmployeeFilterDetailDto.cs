using IczpNet.Organization.BaseDtos;
using IczpNet.Organization.Employees;

namespace IczpNet.Organization.EmployeeFilters.Dtos
{
    public class EmployeeFilterDetailDto : BaseDto
    {
        public virtual string Description { get; set; }

        public virtual EmployeeFilterParameter FilterParameter { get; set; }
    }
}
