using AutoMapper;
using IczpNet.Organization.Companys;
using IczpNet.Organization.Companys.Dtos;
using IczpNet.Organization.CompanyTypes;
using IczpNet.Organization.CompanyTypes.Dtos;
using IczpNet.Organization.Departments;
using IczpNet.Organization.Departments.Dtos;
using IczpNet.Organization.DepartmentTypes;
using IczpNet.Organization.DepartmentTypes.Dtos;
using IczpNet.Organization.EmployeeFilters.Dtos;
using IczpNet.Organization.EmployeeFilters;
using IczpNet.Organization.Employees;
using IczpNet.Organization.Employees.Dtos;
using IczpNet.Organization.EmployeeStates;
using IczpNet.Organization.EmployeeStates.Dtos;
using IczpNet.Organization.EmployeeTypes;
using IczpNet.Organization.EmployeeTypes.Dtos;
using IczpNet.Organization.Functionals;
using IczpNet.Organization.Functionals.Dtos;
using IczpNet.Organization.Positions;
using IczpNet.Organization.Positions.Dtos;
using IczpNet.Organization.PositionTypes;
using IczpNet.Organization.PositionTypes.Dtos;
using IczpNet.Organization.PostGrades;
using IczpNet.Organization.PostGrades.Dtos;
using IczpNet.Organization.PostLevels;
using IczpNet.Organization.PostLevels.Dtos;
using IczpNet.Organization.PostRanks;
using IczpNet.Organization.PostRanks.Dtos;
using IczpNet.Organization.PostTypes;
using IczpNet.Organization.PostTypes.Dtos;
using Volo.Abp.AutoMapper;
using IczpNet.Organization.AutoMappers;

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
        CreateMap<DepartmentType, DepartmentTypeWithParentDto>(MemberList.Destination);
        CreateMap<DepartmentType, DepartmentTypeWithChildsDto>(MemberList.Destination)
            // MaxDepth
            //.MaxDepth(depth: 3)
            .ForMember(s => s.ChildsCount, map => map.MapFrom(d => d.GetChildsCount()))
             //.ForMember(s => s.UserCount, map => map.MapFrom(d => d.GetUserCount()))
             ;
        CreateMap<DepartmentTypeCreateInput, DepartmentType>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<DepartmentTypeUpdateInput, DepartmentType>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<DepartmentType, DepartmentTypeInfo>();
        CreateMap<DepartmentTypeInfo, DepartmentTypeWithChildsDto>()
            .Ignore(x => x.ChildsCount)
            .Ignore(x => x.Childs);


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

        //CompanyType
        CreateMap<CompanyType, CompanyTypeDto>();
        CreateMap<CompanyType, CompanyTypeDetailDto>();
        CreateMap<CompanyTypeCreateInput, CompanyType>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<CompanyTypeUpdateInput, CompanyType>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();

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

        //PositionType
        CreateMap<PositionType, PositionTypeDto>();
        CreateMap<PositionType, PositionTypeDetailDto>();
        CreateMap<PositionTypeCreateInput, PositionType>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<PositionTypeUpdateInput, PositionType>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();

        //Employee
        CreateMap<Employee, EmployeeDto>().ForMember(x => x.PostionIdList, o => o.MapFrom(x => x.GetPositionIdList()));
        CreateMap<Employee, EmployeeDetailDto>().ForMember(x => x.PostionIdList, o => o.MapFrom(x => x.GetPositionIdList()));
        CreateMap<EmployeeCreateInput, Employee>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<EmployeeUpdateInput, Employee>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();

        //EmployeeState
        CreateMap<EmployeeState, EmployeeStateDto>();
        CreateMap<EmployeeState, EmployeeStateDetailDto>();
        CreateMap<EmployeeStateCreateInput, EmployeeState>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<EmployeeStateUpdateInput, EmployeeState>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();

        //EmployeeType
        CreateMap<EmployeeType, EmployeeTypeDto>();
        CreateMap<EmployeeType, EmployeeTypeDetailDto>();
        CreateMap<EmployeeTypeCreateInput, EmployeeType>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<EmployeeTypeUpdateInput, EmployeeType>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();

        //EmployeeFilter
        CreateMap<EmployeeFilter, EmployeeFilterDto>();
        CreateMap<EmployeeFilter, EmployeeFilterDetailDto>()
            //.ForMember(x => x.Parameter, o => o.MapFrom(new FilterParameterResolver()))
            .ForMember(x => x.FilterParameter, o => o.MapFrom(x => x.GetFilterParameter()))
            //.ConvertUsing(typeof(FilterParameterConverter))
            ;
        CreateMap<EmployeeFilterCreateInput, EmployeeFilter>(MemberList.None).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<EmployeeFilterUpdateInput, EmployeeFilter>(MemberList.None).IgnoreAllPropertiesWithAnInaccessibleSetter();

        //PostType
        CreateMap<PostType, PostTypeDto>();
        CreateMap<PostType, PostTypeDetailDto>();
        CreateMap<PostTypeCreateInput, PostType>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<PostTypeUpdateInput, PostType>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();

        //PostRank
        CreateMap<PostRank, PostRankDto>();
        CreateMap<PostRank, PostRankDetailDto>();
        CreateMap<PostRankCreateInput, PostRank>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<PostRankUpdateInput, PostRank>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();

        //PostGrade
        CreateMap<PostGrade, PostGradeDto>();
        CreateMap<PostGrade, PostGradeDetailDto>();
        CreateMap<PostGradeCreateInput, PostGrade>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<PostGradeUpdateInput, PostGrade>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();

        //PostLevel
        CreateMap<PostLevel, PostLevelDto>();
        CreateMap<PostLevel, PostLevelDetailDto>();
        CreateMap<PostLevelCreateInput, PostLevel>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();
        CreateMap<PostLevelUpdateInput, PostLevel>(MemberList.Source).IgnoreAllPropertiesWithAnInaccessibleSetter();

    }
}
