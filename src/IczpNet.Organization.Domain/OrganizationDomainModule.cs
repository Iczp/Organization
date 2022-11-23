using IczpNet.AbpCommons;
using IczpNet.AbpTrees;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace IczpNet.Organization;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(OrganizationDomainSharedModule)
)]
[DependsOn(typeof(AbpCommonsDomainModule))]
[DependsOn(typeof(AbpTreesDomainModule))]
public class OrganizationDomainModule : AbpModule
{

}
