using MyTattooShop.Storage.EntityFrameworkCore;
using MyTattooShop.SocialEngagement.EntityFrameworkCore;
using MyTattooShop.TikTok.EntityFrameworkCore;
using MyTattooShop.WhatsApp.EntityFrameworkCore;
using MyTattooShop.Instagram.EntityFrameworkCore;
using MyTattooShop.TattooJourney.EntityFrameworkCore;
using MyTattooShop.CustomerJourney.EntityFrameworkCore;
using MyTattooShop.CustomerChat.EntityFrameworkCore;
using MyTattooShop.Calendar.EntityFrameworkCore;
using MyTattooShop.Catalog.EntityFrameworkCore;
using System;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Uow;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Sqlite;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.BlobStoring.Database.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using Volo.Abp.Studio;

namespace MyTattooShop.EntityFrameworkCore;

[DependsOn(
    typeof(StorageEntityFrameworkCoreModule),
    typeof(SocialEngagementEntityFrameworkCoreModule),
    typeof(TikTokEntityFrameworkCoreModule),
    typeof(WhatsAppEntityFrameworkCoreModule),
    typeof(InstagramEntityFrameworkCoreModule),
    typeof(TattooJourneyEntityFrameworkCoreModule),
    typeof(CustomerJourneyEntityFrameworkCoreModule),
    typeof(CustomerChatEntityFrameworkCoreModule),
    typeof(CalendarEntityFrameworkCoreModule),
    typeof(CatalogEntityFrameworkCoreModule),
    typeof(MyTattooShopDomainModule),
    typeof(AbpPermissionManagementEntityFrameworkCoreModule),
    typeof(AbpSettingManagementEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreSqliteModule),
    typeof(AbpBackgroundJobsEntityFrameworkCoreModule),
    typeof(AbpAuditLoggingEntityFrameworkCoreModule),
    typeof(AbpFeatureManagementEntityFrameworkCoreModule),
    typeof(AbpIdentityEntityFrameworkCoreModule),
    typeof(AbpOpenIddictEntityFrameworkCoreModule),
    typeof(AbpTenantManagementEntityFrameworkCoreModule),
    typeof(BlobStoringDatabaseEntityFrameworkCoreModule)
    )]
public class MyTattooShopEntityFrameworkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {

        MyTattooShopEfCoreEntityExtensionMappings.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<MyTattooShopDbContext>(options =>
        {
                /* Remove "includeAllEntities: true" to create
                 * default repositories only for aggregate roots */
            options.AddDefaultRepositories(includeAllEntities: true);
        });

        if (AbpStudioAnalyzeHelper.IsInAnalyzeMode)
        {
            return;
        }

        Configure<AbpDbContextOptions>(options =>
        {
            /* The main point to change your DBMS.
             * See also MyTattooShopDbContextFactory for EF Core tooling. */

            options.UseSqlite();

        });
        
        context.Services.AddAlwaysDisableUnitOfWorkTransaction();
        Configure<AbpUnitOfWorkDefaultOptions>(options =>
        {
            options.TransactionBehavior = UnitOfWorkTransactionBehavior.Disabled;
        });
    }
}
