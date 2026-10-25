using MyTattooShop.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MyTattooShop.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MyTattooShopEntityFrameworkCoreModule),
    typeof(MyTattooShopApplicationContractsModule)
)]
public class MyTattooShopDbMigratorModule : AbpModule
{
}
