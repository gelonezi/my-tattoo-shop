using MyTattooShop.Storage;
using MyTattooShop.SocialEngagement;
using MyTattooShop.TikTok;
using MyTattooShop.WhatsApp;
using MyTattooShop.Instagram;
using MyTattooShop.TattooJourney;
using MyTattooShop.CustomerJourney;
using MyTattooShop.CustomerChat;
using MyTattooShop.Calendar;
using MyTattooShop.Catalog;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.TenantManagement;

namespace MyTattooShop;

[DependsOn(
    typeof(StorageHttpApiClientModule),
    typeof(SocialEngagementHttpApiClientModule),
    typeof(TikTokHttpApiClientModule),
    typeof(WhatsAppHttpApiClientModule),
    typeof(InstagramHttpApiClientModule),
    typeof(TattooJourneyHttpApiClientModule),
    typeof(CustomerJourneyHttpApiClientModule),
    typeof(CustomerChatHttpApiClientModule),
    typeof(CalendarHttpApiClientModule),
    typeof(CatalogHttpApiClientModule),
    typeof(MyTattooShopApplicationContractsModule),
    typeof(AbpPermissionManagementHttpApiClientModule),
    typeof(AbpFeatureManagementHttpApiClientModule),
    typeof(AbpAccountHttpApiClientModule),
    typeof(AbpIdentityHttpApiClientModule),
    typeof(AbpTenantManagementHttpApiClientModule),
    typeof(AbpSettingManagementHttpApiClientModule)
)]
public class MyTattooShopHttpApiClientModule : AbpModule
{
    public const string RemoteServiceName = "Default";

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(MyTattooShopApplicationContractsModule).Assembly,
            RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<MyTattooShopHttpApiClientModule>();
        });
    }
}
