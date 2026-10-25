using Volo.Abp.Modularity;

namespace MyTattooShop;

public abstract class MyTattooShopApplicationTestBase<TStartupModule> : MyTattooShopTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
