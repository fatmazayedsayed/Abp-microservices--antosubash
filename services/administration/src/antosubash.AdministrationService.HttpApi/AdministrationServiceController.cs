using antosubash.AdministrationService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace antosubash.AdministrationService;

public abstract class AdministrationServiceController : AbpControllerBase
{
    protected AdministrationServiceController()
    {
        LocalizationResource = typeof(AdministrationServiceResource);
    }
}
