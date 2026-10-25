using Volo.Abp.Modularity;

namespace MyTattooShop.Storage;

[DependsOn(
    typeof(StorageApplicationModule),
    typeof(StorageDomainTestModule)
    )]
public class StorageApplicationTestModule : AbpModule
{

}
