using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyTattooShop.Storage;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class StorageInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<StorageInstallerModule>();
        });
    }
}
