using Volo.Abp.Modularity;

namespace MyTattooShop.Catalog;

[DependsOn(
    typeof(CatalogApplicationModule),
    typeof(CatalogDomainTestModule)
    )]
public class CatalogApplicationTestModule : AbpModule
{

}
