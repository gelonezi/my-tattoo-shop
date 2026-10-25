using Volo.Abp.Modularity;

namespace MyTattooShop.TattooJourney;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class TattooJourneyDomainTestBase<TStartupModule> : TattooJourneyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
