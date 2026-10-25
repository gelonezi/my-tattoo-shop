using Volo.Abp.Modularity;

namespace MyTattooShop;

/* Inherit from this class for your domain layer tests. */
public abstract class MyTattooShopDomainTestBase<TStartupModule> : MyTattooShopTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
