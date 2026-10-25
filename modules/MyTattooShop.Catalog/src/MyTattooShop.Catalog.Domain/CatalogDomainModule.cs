using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MyTattooShop.Catalog;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(CatalogDomainSharedModule)
)]
public class CatalogDomainModule : AbpModule
{

}
