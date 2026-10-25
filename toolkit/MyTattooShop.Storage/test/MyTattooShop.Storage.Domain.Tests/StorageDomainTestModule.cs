using Volo.Abp.Modularity;

namespace MyTattooShop.Storage;

[DependsOn(
    typeof(StorageDomainModule),
    typeof(StorageTestBaseModule)
)]
public class StorageDomainTestModule : AbpModule
{

}
