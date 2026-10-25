using Volo.Abp.Modularity;

namespace MyTattooShop.WhatsApp;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class WhatsAppDomainTestBase<TStartupModule> : WhatsAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
