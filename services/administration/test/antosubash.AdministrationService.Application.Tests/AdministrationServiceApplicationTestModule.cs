using Volo.Abp.Modularity;

namespace antosubash.AdministrationService;

[DependsOn(
    typeof(AdministrationServiceApplicationModule),
    typeof(AdministrationServiceDomainTestModule)
    )]
public class AdministrationServiceApplicationTestModule : AbpModule
{

}
