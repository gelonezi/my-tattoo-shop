using Volo.Abp.Reflection;

namespace MyTattooShop.TattooJourney.Permissions;

public class TattooJourneyPermissions
{
    public const string GroupName = "TattooJourney";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(TattooJourneyPermissions));
    }
}
