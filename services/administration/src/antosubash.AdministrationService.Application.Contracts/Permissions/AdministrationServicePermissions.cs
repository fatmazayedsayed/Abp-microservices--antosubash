using Volo.Abp.Reflection;

namespace antosubash.AdministrationService.Permissions;

public class AdministrationServicePermissions
{
    public const string GroupName = "AdministrationService";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AdministrationServicePermissions));
    }
}
