using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MyTattooShop.Data;

/* This is used if database provider does't define
 * IMyTattooShopDbSchemaMigrator implementation.
 */
public class NullMyTattooShopDbSchemaMigrator : IMyTattooShopDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
