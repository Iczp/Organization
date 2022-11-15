using Volo.Abp.Modularity;

namespace IczpNet.Organization;

[DependsOn(
    typeof(OrganizationApplicationModule),
    typeof(OrganizationDomainTestModule)
    )]
public class OrganizationApplicationTestModule : AbpModule
{

}
