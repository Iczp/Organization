using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using IczpNet.Organization.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;
using IczpNet.AbpTrees;
using IczpNet.AbpCommons;

namespace IczpNet.Organization;

[DependsOn(
    typeof(AbpValidationModule)
)]
[DependsOn(typeof(AbpCommonsDomainSharedModule))]
[DependsOn(typeof(AbpTreesDomainSharedModule))]
public class OrganizationDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<OrganizationDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<OrganizationResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/Organization");
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("Organization", typeof(OrganizationResource));
        });
    }
}
