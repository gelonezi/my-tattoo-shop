using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyTattooShop.Instagram;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class InstagramInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<InstagramInstallerModule>();
        });
    }
}
