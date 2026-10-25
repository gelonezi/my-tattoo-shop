using Volo.Abp.Reflection;

namespace MyTattooShop.Storage.Permissions;

public class StoragePermissions
{
    public const string GroupName = "Storage";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(StoragePermissions));
    }
}
