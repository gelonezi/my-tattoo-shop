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
using Volo.Abp.Account;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.TenantManagement;

namespace MyTattooShop;

[DependsOn(
    typeof(StorageApplicationContractsModule),
    typeof(SocialEngagementApplicationContractsModule),
    typeof(TikTokApplicationContractsModule),
    typeof(WhatsAppApplicationContractsModule),
    typeof(InstagramApplicationContractsModule),
    typeof(TattooJourneyApplicationContractsModule),
    typeof(CustomerJourneyApplicationContractsModule),
    typeof(CustomerChatApplicationContractsModule),
    typeof(CalendarApplicationContractsModule),
    typeof(CatalogApplicationContractsModule),
    typeof(MyTattooShopDomainSharedModule),
    typeof(AbpFeatureManagementApplicationContractsModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpIdentityApplicationContractsModule),
    typeof(AbpAccountApplicationContractsModule),
    typeof(AbpTenantManagementApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationContractsModule)
)]
public class MyTattooShopApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        MyTattooShopDtoExtensions.Configure();
    }
}
