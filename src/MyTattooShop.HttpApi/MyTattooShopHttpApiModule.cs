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
using Localization.Resources.AbpUi;
using MyTattooShop.Localization;
using Volo.Abp.Account;
using Volo.Abp.SettingManagement;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.Localization;
using Volo.Abp.TenantManagement;

namespace MyTattooShop;

 [DependsOn(
    typeof(StorageHttpApiModule),
    typeof(SocialEngagementHttpApiModule),
    typeof(TikTokHttpApiModule),
    typeof(WhatsAppHttpApiModule),
    typeof(InstagramHttpApiModule),
    typeof(TattooJourneyHttpApiModule),
    typeof(CustomerJourneyHttpApiModule),
    typeof(CustomerChatHttpApiModule),
    typeof(CalendarHttpApiModule),
    typeof(CatalogHttpApiModule),
    typeof(MyTattooShopApplicationContractsModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule),
    typeof(AbpAccountHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpTenantManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule)
    )]
public class MyTattooShopHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<MyTattooShopResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
