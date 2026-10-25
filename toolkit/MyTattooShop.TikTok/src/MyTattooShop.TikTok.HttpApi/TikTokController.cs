using MyTattooShop.TikTok.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyTattooShop.TikTok;

public abstract class TikTokController : AbpControllerBase
{
    protected TikTokController()
    {
        LocalizationResource = typeof(TikTokResource);
    }
}
