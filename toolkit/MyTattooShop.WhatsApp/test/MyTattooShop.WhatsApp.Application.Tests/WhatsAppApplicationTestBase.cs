using Volo.Abp.Modularity;

namespace MyTattooShop.WhatsApp;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class WhatsAppApplicationTestBase<TStartupModule> : WhatsAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
