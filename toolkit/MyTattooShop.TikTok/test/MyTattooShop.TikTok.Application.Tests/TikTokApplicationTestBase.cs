using Volo.Abp.Modularity;

namespace MyTattooShop.TikTok;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class TikTokApplicationTestBase<TStartupModule> : TikTokTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
