using AutoMapper;
using IczpNet.Organization.Departments;
using IczpNet.Organization.Departments.Dtos;
using IczpNet.Organization.DepartmentTypes;
using IczpNet.Organization.DepartmentTypes.Dtos;
using Volo.Abp.AutoMapper;
namespace IczpNet.Organization;

public class OrganizationApplicationAutoMapperProfile : Profile
{
    public OrganizationApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        //Department
        CreateMap<Department, DepartmentDto>();
        CreateMap<Department, DepartmentDetailDto>();
        CreateMap<Department, DepartmentWithParentDto>(MemberList.Destination);
        CreateMap<Department, DepartmentWithChildsDto>(MemberList.Destination)
            // MaxDepth
            //.MaxDepth(depth: 3)
            .ForMember(s => s.ChildsCount, map => map.MapFrom(d => d.GetChildsCount()))
             //.ForMember(s => s.UserCount, map => map.MapFrom(d => d.GetUserCount()))
             ;
        CreateMap<DepartmentCreateInput, Department>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<DepartmentUpdateInput, Department>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<Department, DepartmentInfo>();
        CreateMap<DepartmentInfo, DepartmentWithChildsDto>()
            .Ignore(x => x.ChildsCount)
            .Ignore(x => x.Childs);

        //DepartmentType
        CreateMap<DepartmentType, DepartmentTypeDto>();
        CreateMap<DepartmentType, DepartmentTypeDetailDto>();
        CreateMap<DepartmentTypeCreateInput, DepartmentType>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<DepartmentTypeUpdateInput, DepartmentType>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
    }
}
