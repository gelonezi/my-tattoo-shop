using Volo.Abp.Reflection;

namespace MyTattooShop.Instagram.Permissions;

public class InstagramPermissions
{
    public const string GroupName = "Instagram";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(InstagramPermissions));
    }
}
