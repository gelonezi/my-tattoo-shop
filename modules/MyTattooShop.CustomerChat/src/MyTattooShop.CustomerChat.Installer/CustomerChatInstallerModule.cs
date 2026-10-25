using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyTattooShop.CustomerChat;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class CustomerChatInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CustomerChatInstallerModule>();
        });
    }
}
