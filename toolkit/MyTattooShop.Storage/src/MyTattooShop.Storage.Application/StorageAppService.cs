using MyTattooShop.Storage.Localization;
using Volo.Abp.Application.Services;

namespace MyTattooShop.Storage;

public abstract class StorageAppService : ApplicationService
{
    protected StorageAppService()
    {
        LocalizationResource = typeof(StorageResource);
        ObjectMapperContext = typeof(StorageApplicationModule);
    }
}
