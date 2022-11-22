using antosubash.IdentityService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace antosubash.IdentityService;

public abstract class IdentityServiceController : AbpControllerBase
{
    protected IdentityServiceController()
    {
        LocalizationResource = typeof(IdentityServiceResource);
    }
}
