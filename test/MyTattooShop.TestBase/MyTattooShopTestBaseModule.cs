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
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Authorization;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Threading;

namespace MyTattooShop;

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
    typeof(AbpAutofacModule),
    typeof(AbpTestBaseModule),
    typeof(AbpAuthorizationModule),
    typeof(AbpBackgroundJobsAbstractionsModule)
)]
public class MyTattooShopTestBaseModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options =>
        {
            options.IsJobExecutionEnabled = false;
        });

        context.Services.AddAlwaysAllowAuthorization();
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        SeedTestData(context);
    }

    private static void SeedTestData(ApplicationInitializationContext context)
    {
        AsyncHelper.RunSync(async () =>
        {
            using (var scope = context.ServiceProvider.CreateScope())
            {
                await scope.ServiceProvider
                    .GetRequiredService<IDataSeeder>()
                    .SeedAsync();
            }
        });
    }
}
