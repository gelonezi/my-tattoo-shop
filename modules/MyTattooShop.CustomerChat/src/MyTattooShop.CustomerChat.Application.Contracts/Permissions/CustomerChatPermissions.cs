using Volo.Abp.Reflection;

namespace MyTattooShop.CustomerChat.Permissions;

public class CustomerChatPermissions
{
    public const string GroupName = "CustomerChat";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CustomerChatPermissions));
    }
}
