using Volo.Abp.Modularity;

namespace MyTattooShop.TattooJourney;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class TattooJourneyApplicationTestBase<TStartupModule> : TattooJourneyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
