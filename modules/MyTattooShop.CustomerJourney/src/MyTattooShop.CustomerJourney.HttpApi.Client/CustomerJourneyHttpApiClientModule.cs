using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyTattooShop.CustomerJourney;

[DependsOn(
    typeof(CustomerJourneyApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class CustomerJourneyHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(CustomerJourneyApplicationContractsModule).Assembly,
            CustomerJourneyRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CustomerJourneyHttpApiClientModule>();
        });

    }
}
