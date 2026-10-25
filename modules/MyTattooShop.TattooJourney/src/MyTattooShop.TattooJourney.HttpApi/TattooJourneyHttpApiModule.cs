using Localization.Resources.AbpUi;
using MyTattooShop.TattooJourney.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace MyTattooShop.TattooJourney;

[DependsOn(
    typeof(TattooJourneyApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class TattooJourneyHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(TattooJourneyHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<TattooJourneyResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
