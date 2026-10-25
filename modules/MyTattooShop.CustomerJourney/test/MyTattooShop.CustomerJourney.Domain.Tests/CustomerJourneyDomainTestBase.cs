using Volo.Abp.Modularity;

namespace MyTattooShop.CustomerJourney;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class CustomerJourneyDomainTestBase<TStartupModule> : CustomerJourneyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
