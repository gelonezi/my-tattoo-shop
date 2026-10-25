using MyTattooShop.Instagram.Localization;
using Volo.Abp.Application.Services;

namespace MyTattooShop.Instagram;

public abstract class InstagramAppService : ApplicationService
{
    protected InstagramAppService()
    {
        LocalizationResource = typeof(InstagramResource);
        ObjectMapperContext = typeof(InstagramApplicationModule);
    }
}
