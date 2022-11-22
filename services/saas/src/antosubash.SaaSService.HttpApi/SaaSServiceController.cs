using antosubash.SaaSService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace antosubash.SaaSService;

public abstract class SaaSServiceController : AbpControllerBase
{
    protected SaaSServiceController()
    {
        LocalizationResource = typeof(SaaSServiceResource);
    }
}
