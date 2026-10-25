using Volo.Abp.Modularity;

namespace MyTattooShop.Instagram;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class InstagramDomainTestBase<TStartupModule> : InstagramTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
