using Localization.Resources.AbpUi;
using MyTattooShop.SocialEngagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace MyTattooShop.SocialEngagement;

[DependsOn(
    typeof(SocialEngagementApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class SocialEngagementHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(SocialEngagementHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<SocialEngagementResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
