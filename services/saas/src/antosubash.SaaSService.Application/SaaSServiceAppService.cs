using antosubash.SaaSService.Localization;
using Volo.Abp.Application.Services;

namespace antosubash.SaaSService;

public abstract class SaaSServiceAppService : ApplicationService
{
    protected SaaSServiceAppService()
    {
        LocalizationResource = typeof(SaaSServiceResource);
        ObjectMapperContext = typeof(SaaSServiceApplicationModule);
    }
}
