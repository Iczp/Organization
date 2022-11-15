using IczpNet.Organization.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace IczpNet.Organization;

public abstract class OrganizationController : AbpControllerBase
{
    protected OrganizationController()
    {
        LocalizationResource = typeof(OrganizationResource);
    }
}
