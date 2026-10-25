using MyTattooShop.Storage.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyTattooShop.Storage;

public abstract class StorageController : AbpControllerBase
{
    protected StorageController()
    {
        LocalizationResource = typeof(StorageResource);
    }
}
