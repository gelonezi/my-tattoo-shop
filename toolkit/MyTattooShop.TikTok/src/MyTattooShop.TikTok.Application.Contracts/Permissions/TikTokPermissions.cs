using Volo.Abp.Reflection;

namespace MyTattooShop.TikTok.Permissions;

public class TikTokPermissions
{
    public const string GroupName = "TikTok";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(TikTokPermissions));
    }
}
