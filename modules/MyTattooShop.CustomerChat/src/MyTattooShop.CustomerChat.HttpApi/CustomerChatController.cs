using MyTattooShop.CustomerChat.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyTattooShop.CustomerChat;

public abstract class CustomerChatController : AbpControllerBase
{
    protected CustomerChatController()
    {
        LocalizationResource = typeof(CustomerChatResource);
    }
}
