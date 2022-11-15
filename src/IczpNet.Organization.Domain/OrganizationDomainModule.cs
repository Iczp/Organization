using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace IczpNet.Organization;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(OrganizationDomainSharedModule)
)]
public class OrganizationDomainModule : AbpModule
{

}
