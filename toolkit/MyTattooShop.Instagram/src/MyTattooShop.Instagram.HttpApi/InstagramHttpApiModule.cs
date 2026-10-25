using Localization.Resources.AbpUi;
using MyTattooShop.Instagram.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace MyTattooShop.Instagram;

[DependsOn(
    typeof(InstagramApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class InstagramHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(InstagramHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<InstagramResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
