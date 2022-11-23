using AutoMapper;
using IczpNet.AbpCommons.Extensions;
using IczpNet.Organization.EmployeeFilters;
using IczpNet.Organization.EmployeeFilters.Dtos;
using IczpNet.Organization.Employees;
using System;

namespace IczpNet.Organization.AutoMappers
{
    public class FilterParameterResolver : IValueResolver<EmployeeFilter, EmployeeFilterDetailDto, EmployeeFilterParameter>
    {
        public EmployeeFilterParameter Resolve(EmployeeFilter source, EmployeeFilterDetailDto destination, EmployeeFilterParameter destMember, ResolutionContext context)
        {
            try
            {
                return source.GetFilterParameter();
            }
            catch (Exception ex)
            {
                throw new Exception($"{typeof(FilterParameterResolver)} error:{ex.Message}.");
            }
        }
    }
}
