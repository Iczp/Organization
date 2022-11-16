using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using IczpNet.AbpTrees;
using IczpNet.AbpCommons;

namespace IczpNet.Organization;

[DependsOn(
    typeof(OrganizationDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
[DependsOn(typeof(AbpCommonsApplicationContractsModule))]
[DependsOn(typeof(AbpTreesApplicationContractsModule))]
public class OrganizationApplicationContractsModule : AbpModule
{

}
