using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MyTattooShop.Storage;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(StorageDomainSharedModule)
)]
public class StorageDomainModule : AbpModule
{

}
