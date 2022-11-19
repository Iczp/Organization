using IczpNet.AbpTrees;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace IczpNet.Organization;

[DependsOn(
    typeof(AbpVirtualFileSystemModule),
    typeof(AbpTreesInstallerModule)
    )]
public class OrganizationInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<OrganizationInstallerModule>();
        });
    }
}
