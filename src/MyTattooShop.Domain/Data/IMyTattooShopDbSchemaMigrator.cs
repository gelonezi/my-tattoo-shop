using System.Threading.Tasks;

namespace MyTattooShop.Data;

public interface IMyTattooShopDbSchemaMigrator
{
    Task MigrateAsync();
}
