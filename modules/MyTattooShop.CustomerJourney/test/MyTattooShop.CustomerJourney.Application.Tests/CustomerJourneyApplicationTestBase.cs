using Volo.Abp.Modularity;

namespace MyTattooShop.CustomerJourney;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class CustomerJourneyApplicationTestBase<TStartupModule> : CustomerJourneyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
