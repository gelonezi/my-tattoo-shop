using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyTattooShop.Calendar;

[DependsOn(
    typeof(CalendarApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class CalendarHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(CalendarApplicationContractsModule).Assembly,
            CalendarRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CalendarHttpApiClientModule>();
        });

    }
}
