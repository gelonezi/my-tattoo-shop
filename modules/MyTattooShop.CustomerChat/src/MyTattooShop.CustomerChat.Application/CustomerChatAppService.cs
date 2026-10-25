using MyTattooShop.CustomerChat.Localization;
using Volo.Abp.Application.Services;

namespace MyTattooShop.CustomerChat;

public abstract class CustomerChatAppService : ApplicationService
{
    protected CustomerChatAppService()
    {
        LocalizationResource = typeof(CustomerChatResource);
        ObjectMapperContext = typeof(CustomerChatApplicationModule);
    }
}
