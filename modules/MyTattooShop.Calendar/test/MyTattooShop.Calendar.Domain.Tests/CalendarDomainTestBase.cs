using Volo.Abp.Modularity;

namespace MyTattooShop.Calendar;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class CalendarDomainTestBase<TStartupModule> : CalendarTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
