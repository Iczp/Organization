using Localization.Resources.AbpUi;
using IczpNet.Organization.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace IczpNet.Organization;

[DependsOn(
    typeof(OrganizationApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class OrganizationHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(OrganizationHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<OrganizationResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
