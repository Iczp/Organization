using IczpNet.Organization.Localization;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.BaseEntitys;

public abstract class OrganizationAppService : ApplicationService
{
    protected OrganizationAppService()
    {
        LocalizationResource = typeof(OrganizationResource);
        ObjectMapperContext = typeof(OrganizationApplicationModule);
    }
}
