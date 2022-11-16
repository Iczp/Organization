using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using IczpNet.AbpTrees;
using IczpNet.AbpCommons;

namespace IczpNet.Organization;

[DependsOn(
    typeof(OrganizationDomainModule),
    typeof(OrganizationApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
[DependsOn(typeof(AbpCommonsApplicationModule))]
[DependsOn(typeof(AbpTreesApplicationModule))]
public class OrganizationApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<OrganizationApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<OrganizationApplicationModule>(validate: true);
        });
    }
}
