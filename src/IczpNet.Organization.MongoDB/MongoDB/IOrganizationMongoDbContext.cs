using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace IczpNet.Organization.MongoDB;

[ConnectionStringName(OrganizationDbProperties.ConnectionStringName)]
public interface IOrganizationMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
