using IczpNet.Organization.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace IczpNet.Organization;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(OrganizationEntityFrameworkCoreTestModule)
    )]
public class OrganizationDomainTestModule : AbpModule
{

}
