using Localization.Resources.AbpUi;
using MyTattooShop.WhatsApp.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace MyTattooShop.WhatsApp;

[DependsOn(
    typeof(WhatsAppApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class WhatsAppHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(WhatsAppHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<WhatsAppResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
