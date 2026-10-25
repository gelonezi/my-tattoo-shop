using MyTattooShop.TikTok.Localization;
using Volo.Abp.Application.Services;

namespace MyTattooShop.TikTok;

public abstract class TikTokAppService : ApplicationService
{
    protected TikTokAppService()
    {
        LocalizationResource = typeof(TikTokResource);
        ObjectMapperContext = typeof(TikTokApplicationModule);
    }
}
