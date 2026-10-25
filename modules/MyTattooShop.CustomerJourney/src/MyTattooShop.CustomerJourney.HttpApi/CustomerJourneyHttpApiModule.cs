using Localization.Resources.AbpUi;
using MyTattooShop.CustomerJourney.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace MyTattooShop.CustomerJourney;

[DependsOn(
    typeof(CustomerJourneyApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class CustomerJourneyHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(CustomerJourneyHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<CustomerJourneyResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
