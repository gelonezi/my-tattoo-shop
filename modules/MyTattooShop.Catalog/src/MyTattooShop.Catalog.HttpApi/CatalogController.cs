using MyTattooShop.Catalog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyTattooShop.Catalog;

public abstract class CatalogController : AbpControllerBase
{
    protected CatalogController()
    {
        LocalizationResource = typeof(CatalogResource);
    }
}
