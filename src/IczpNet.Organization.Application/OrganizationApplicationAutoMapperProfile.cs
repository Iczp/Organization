using AutoMapper;
using IczpNet.Organization.Departments;
using IczpNet.Organization.Departments.Dtos;
using IczpNet.Organization.DepartmentTypes;
using IczpNet.Organization.DepartmentTypes.Dtos;
using IczpNet.Organization.Functionals.Dtos;
using IczpNet.Organization.Functionals;
using Volo.Abp.AutoMapper;
using IczpNet.Organization.Companys.Dtos;
using IczpNet.Organization.Companys;
using IczpNet.Organization.Positions.Dtos;
using IczpNet.Organization.Positions;

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


        //Functional
        CreateMap<Functional, FunctionalDto>();
        CreateMap<Functional, FunctionalDetailDto>();
        CreateMap<Functional, FunctionalWithParentDto>(MemberList.Destination);
        CreateMap<Functional, FunctionalWithChildsDto>(MemberList.Destination)
            // MaxDepth
            //.MaxDepth(depth: 3)
            .ForMember(s => s.ChildsCount, map => map.MapFrom(d => d.GetChildsCount()))
             //.ForMember(s => s.UserCount, map => map.MapFrom(d => d.GetUserCount()))
             ;
        CreateMap<FunctionalCreateInput, Functional>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<FunctionalUpdateInput, Functional>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<Functional, FunctionalInfo>();
        CreateMap<FunctionalInfo, FunctionalWithChildsDto>()
            .Ignore(x => x.ChildsCount)
            .Ignore(x => x.Childs);

        //Company
        CreateMap<Company, CompanyDto>();
        CreateMap<Company, CompanyDetailDto>();
        CreateMap<Company, CompanyWithParentDto>(MemberList.Destination);
        CreateMap<Company, CompanyWithChildsDto>(MemberList.Destination)
            // MaxDepth
            //.MaxDepth(depth: 3)
            .ForMember(s => s.ChildsCount, map => map.MapFrom(d => d.GetChildsCount()))
             //.ForMember(s => s.UserCount, map => map.MapFrom(d => d.GetUserCount()))
             ;
        CreateMap<CompanyCreateInput, Company>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<CompanyUpdateInput, Company>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<Company, CompanyInfo>();
        CreateMap<CompanyInfo, CompanyWithChildsDto>()
            .Ignore(x => x.ChildsCount)
            .Ignore(x => x.Childs);

        //Position
        CreateMap<Position, PositionDto>();
        CreateMap<Position, PositionDetailDto>();
        CreateMap<Position, PositionWithParentDto>(MemberList.Destination);
        CreateMap<Position, PositionWithChildsDto>(MemberList.Destination)
            // MaxDepth
            //.MaxDepth(depth: 3)
            .ForMember(s => s.ChildsCount, map => map.MapFrom(d => d.GetChildsCount()))
             //.ForMember(s => s.UserCount, map => map.MapFrom(d => d.GetUserCount()))
             ;
        CreateMap<PositionCreateInput, Position>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<PositionUpdateInput, Position>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<Position, PositionInfo>();
        CreateMap<PositionInfo, PositionWithChildsDto>()
            .Ignore(x => x.ChildsCount)
            .Ignore(x => x.Childs);
    }
}
