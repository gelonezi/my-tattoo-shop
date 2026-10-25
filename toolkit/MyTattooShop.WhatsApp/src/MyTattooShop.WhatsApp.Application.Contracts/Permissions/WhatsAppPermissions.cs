using Volo.Abp.Reflection;

namespace MyTattooShop.WhatsApp.Permissions;

public class WhatsAppPermissions
{
    public const string GroupName = "WhatsApp";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(WhatsAppPermissions));
    }
}
