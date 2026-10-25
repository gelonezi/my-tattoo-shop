using MyTattooShop.Instagram.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyTattooShop.Instagram;

public abstract class InstagramController : AbpControllerBase
{
    protected InstagramController()
    {
        LocalizationResource = typeof(InstagramResource);
    }
}
