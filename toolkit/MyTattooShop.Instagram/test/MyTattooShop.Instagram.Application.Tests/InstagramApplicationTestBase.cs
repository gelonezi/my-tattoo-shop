using Volo.Abp.Modularity;

namespace MyTattooShop.Instagram;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class InstagramApplicationTestBase<TStartupModule> : InstagramTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
