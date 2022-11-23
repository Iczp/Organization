using AutoMapper;
using IczpNet.AbpCommons.Extensions;
using IczpNet.Organization.EmployeeFilters;
using IczpNet.Organization.Employees;

namespace IczpNet.Organization.AutoMappers
{
    public class FilterParameterConverter : ITypeConverter<EmployeeFilter, EmployeeFilterParameter>
    {
        public EmployeeFilterParameter Convert(EmployeeFilter source, EmployeeFilterParameter destination, ResolutionContext context)
        {
            return source.MapTo<EmployeeFilterParameter>();
        }
    }
}
