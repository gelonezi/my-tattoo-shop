using Localization.Resources.AbpUi;
using MyTattooShop.TikTok.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace MyTattooShop.TikTok;

[DependsOn(
    typeof(TikTokApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class TikTokHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(TikTokHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<TikTokResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
