using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace IczpNet.Organization;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OrganizationHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class OrganizationConsoleApiClientModule : AbpModule
{

}
