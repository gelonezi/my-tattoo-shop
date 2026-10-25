using MyTattooShop.Localization;
using Volo.Abp.Application.Services;

namespace MyTattooShop;

/* Inherit your application services from this class.
 */
public abstract class MyTattooShopAppService : ApplicationService
{
    protected MyTattooShopAppService()
    {
        LocalizationResource = typeof(MyTattooShopResource);
    }
}
