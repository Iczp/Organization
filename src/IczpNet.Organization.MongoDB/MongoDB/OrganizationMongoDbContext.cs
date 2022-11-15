using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace IczpNet.Organization.MongoDB;

[ConnectionStringName(OrganizationDbProperties.ConnectionStringName)]
public class OrganizationMongoDbContext : AbpMongoDbContext, IOrganizationMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureOrganization();
    }
}
