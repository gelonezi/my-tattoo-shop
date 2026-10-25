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
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.Mapperly;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.TenantManagement;

namespace MyTattooShop;

[DependsOn(
    typeof(StorageApplicationModule),
    typeof(SocialEngagementApplicationModule),
    typeof(TikTokApplicationModule),
    typeof(WhatsAppApplicationModule),
    typeof(InstagramApplicationModule),
    typeof(TattooJourneyApplicationModule),
    typeof(CustomerJourneyApplicationModule),
    typeof(CustomerChatApplicationModule),
    typeof(CalendarApplicationModule),
    typeof(CatalogApplicationModule),
    typeof(MyTattooShopDomainModule),
    typeof(MyTattooShopApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpAccountApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class MyTattooShopApplicationModule : AbpModule
{

}
