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
using System;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Volo.Abp.Autofac;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace MyTattooShop.HttpApi.Client.ConsoleTestApp;

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
    typeof(MyTattooShopHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class MyTattooShopConsoleApiClientModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<AbpHttpClientBuilderOptions>(options =>
        {
            options.ProxyClientBuildActions.Add((remoteServiceName, clientBuilder) =>
            {
                clientBuilder.AddTransientHttpErrorPolicy(
                    policyBuilder => policyBuilder.WaitAndRetryAsync(3, i => TimeSpan.FromSeconds(Math.Pow(2, i)))
                );
            });
        });
    }
}
