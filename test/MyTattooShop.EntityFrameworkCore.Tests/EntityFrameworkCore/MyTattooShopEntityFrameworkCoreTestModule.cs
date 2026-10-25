using MyTattooShop.Storage.EntityFrameworkCore;
using MyTattooShop.Storage;
using MyTattooShop.SocialEngagement.EntityFrameworkCore;
using MyTattooShop.SocialEngagement;
using MyTattooShop.TikTok.EntityFrameworkCore;
using MyTattooShop.TikTok;
using MyTattooShop.WhatsApp.EntityFrameworkCore;
using MyTattooShop.WhatsApp;
using MyTattooShop.Instagram.EntityFrameworkCore;
using MyTattooShop.Instagram;
using MyTattooShop.TattooJourney.EntityFrameworkCore;
using MyTattooShop.TattooJourney;
using MyTattooShop.CustomerJourney.EntityFrameworkCore;
using MyTattooShop.CustomerJourney;
using MyTattooShop.CustomerChat.EntityFrameworkCore;
using MyTattooShop.CustomerChat;
using MyTattooShop.Calendar.EntityFrameworkCore;
using MyTattooShop.Calendar;
using MyTattooShop.Catalog.EntityFrameworkCore;
using MyTattooShop.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Sqlite;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.Uow;

namespace MyTattooShop.EntityFrameworkCore;

[DependsOn(
    typeof(StorageApplicationTestModule),
    typeof(StorageDomainTestModule),
    typeof(StorageEntityFrameworkCoreTestModule),
    typeof(StorageTestBaseModule),
    typeof(SocialEngagementApplicationTestModule),
    typeof(SocialEngagementDomainTestModule),
    typeof(SocialEngagementEntityFrameworkCoreTestModule),
    typeof(SocialEngagementTestBaseModule),
    typeof(TikTokApplicationTestModule),
    typeof(TikTokDomainTestModule),
    typeof(TikTokEntityFrameworkCoreTestModule),
    typeof(TikTokTestBaseModule),
    typeof(WhatsAppApplicationTestModule),
    typeof(WhatsAppDomainTestModule),
    typeof(WhatsAppEntityFrameworkCoreTestModule),
    typeof(WhatsAppTestBaseModule),
    typeof(InstagramApplicationTestModule),
    typeof(InstagramDomainTestModule),
    typeof(InstagramEntityFrameworkCoreTestModule),
    typeof(InstagramTestBaseModule),
    typeof(TattooJourneyApplicationTestModule),
    typeof(TattooJourneyDomainTestModule),
    typeof(TattooJourneyEntityFrameworkCoreTestModule),
    typeof(TattooJourneyTestBaseModule),
    typeof(CustomerJourneyApplicationTestModule),
    typeof(CustomerJourneyDomainTestModule),
    typeof(CustomerJourneyEntityFrameworkCoreTestModule),
    typeof(CustomerJourneyTestBaseModule),
    typeof(CustomerChatApplicationTestModule),
    typeof(CustomerChatDomainTestModule),
    typeof(CustomerChatEntityFrameworkCoreTestModule),
    typeof(CustomerChatTestBaseModule),
    typeof(CalendarApplicationTestModule),
    typeof(CalendarDomainTestModule),
    typeof(CalendarEntityFrameworkCoreTestModule),
    typeof(CalendarTestBaseModule),
    typeof(CatalogApplicationTestModule),
    typeof(CatalogDomainTestModule),
    typeof(CatalogEntityFrameworkCoreTestModule),
    typeof(CatalogTestBaseModule),
    typeof(MyTattooShopApplicationTestModule),
    typeof(MyTattooShopEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreSqliteModule)
)]
public class MyTattooShopEntityFrameworkCoreTestModule : AbpModule
{
    private AbpUnitTestSqliteDatabase? _database;

    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<AbpSqliteOptions>(x => x.BusyTimeout = null);
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<FeatureManagementOptions>(options =>
        {
            options.SaveStaticFeaturesToDatabase = false;
            options.IsDynamicFeatureStoreEnabled = false;
        });
        Configure<PermissionManagementOptions>(options =>
        {
            options.SaveStaticPermissionsToDatabase = false;
            options.IsDynamicPermissionStoreEnabled = false;
        });
        context.Services.AddAlwaysDisableUnitOfWorkTransaction();

        ConfigureInMemorySqlite(context.Services);

    }

    private void ConfigureInMemorySqlite(IServiceCollection services)
    {
        _database = new AbpUnitTestSqliteDatabase();
        _database.CreateTables(
            new MyTattooShopDbContext(new DbContextOptionsBuilder<MyTattooShopDbContext>().UseSqlite(_database.ConnectionString).Options));

        services.Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = _database.ConnectionString;
        });

        services.Configure<AbpDbContextOptions>(options =>
        {
            options.Configure(context =>
            {
                context.UseSqlite();
            });
        });
    }

    public override void OnApplicationShutdown(ApplicationShutdownContext context)
    {
        _database?.Dispose();
    }
}
