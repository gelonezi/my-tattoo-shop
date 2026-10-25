using Volo.Abp.Modularity;

namespace MyTattooShop.Storage;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class StorageApplicationTestBase<TStartupModule> : StorageTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
