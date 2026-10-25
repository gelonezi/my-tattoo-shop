using MyTattooShop.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyTattooShop.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MyTattooShopController : AbpControllerBase
{
    protected MyTattooShopController()
    {
        LocalizationResource = typeof(MyTattooShopResource);
    }
}
