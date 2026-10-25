using Volo.Abp.Modularity;

namespace MyTattooShop.TikTok;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class TikTokDomainTestBase<TStartupModule> : TikTokTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
