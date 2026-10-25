using Volo.Abp.Modularity;

namespace MyTattooShop.SocialEngagement;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class SocialEngagementApplicationTestBase<TStartupModule> : SocialEngagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
