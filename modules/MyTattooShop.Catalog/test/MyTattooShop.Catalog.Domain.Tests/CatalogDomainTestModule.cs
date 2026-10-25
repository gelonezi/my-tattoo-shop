using Volo.Abp.Modularity;

namespace MyTattooShop.Catalog;

[DependsOn(
    typeof(CatalogDomainModule),
    typeof(CatalogTestBaseModule)
)]
public class CatalogDomainTestModule : AbpModule
{

}
