using Volo.Abp.Reflection;

namespace MyTattooShop.CustomerJourney.Permissions;

public class CustomerJourneyPermissions
{
    public const string GroupName = "CustomerJourney";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CustomerJourneyPermissions));
    }
}
