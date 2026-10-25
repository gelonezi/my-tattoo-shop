using Volo.Abp.Modularity;

namespace MyTattooShop.CustomerChat;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class CustomerChatApplicationTestBase<TStartupModule> : CustomerChatTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
