using MyTattooShop.WhatsApp.Localization;
using Volo.Abp.Application.Services;

namespace MyTattooShop.WhatsApp;

public abstract class WhatsAppAppService : ApplicationService
{
    protected WhatsAppAppService()
    {
        LocalizationResource = typeof(WhatsAppResource);
        ObjectMapperContext = typeof(WhatsAppApplicationModule);
    }
}
