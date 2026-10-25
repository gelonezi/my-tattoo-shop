using Volo.Abp.Modularity;

namespace MyTattooShop.Storage;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class StorageDomainTestBase<TStartupModule> : StorageTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
