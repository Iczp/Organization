using IczpNet.Organization.Localization;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.Bases;

public abstract class OrganizationAppService : ApplicationService
{
    protected OrganizationAppService()
    {
        LocalizationResource = typeof(OrganizationResource);
        ObjectMapperContext = typeof(OrganizationApplicationModule);
    }
}
