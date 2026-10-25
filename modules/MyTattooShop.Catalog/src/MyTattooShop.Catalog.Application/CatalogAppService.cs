using MyTattooShop.Catalog.Localization;
using Volo.Abp.Application.Services;

namespace MyTattooShop.Catalog;

public abstract class CatalogAppService : ApplicationService
{
    protected CatalogAppService()
    {
        LocalizationResource = typeof(CatalogResource);
        ObjectMapperContext = typeof(CatalogApplicationModule);
    }
}
