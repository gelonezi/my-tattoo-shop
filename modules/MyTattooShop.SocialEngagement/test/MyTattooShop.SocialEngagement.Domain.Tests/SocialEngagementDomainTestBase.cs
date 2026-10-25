using Volo.Abp.Modularity;

namespace MyTattooShop.SocialEngagement;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class SocialEngagementDomainTestBase<TStartupModule> : SocialEngagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
