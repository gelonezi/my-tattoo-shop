using Volo.Abp.Modularity;

namespace MyTattooShop.CustomerChat;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class CustomerChatDomainTestBase<TStartupModule> : CustomerChatTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
