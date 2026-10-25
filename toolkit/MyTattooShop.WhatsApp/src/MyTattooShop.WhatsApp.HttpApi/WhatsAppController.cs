using MyTattooShop.WhatsApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyTattooShop.WhatsApp;

public abstract class WhatsAppController : AbpControllerBase
{
    protected WhatsAppController()
    {
        LocalizationResource = typeof(WhatsAppResource);
    }
}
