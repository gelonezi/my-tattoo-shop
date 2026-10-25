using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyTattooShop.CustomerJourney;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class CustomerJourneyInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CustomerJourneyInstallerModule>();
        });
    }
}
