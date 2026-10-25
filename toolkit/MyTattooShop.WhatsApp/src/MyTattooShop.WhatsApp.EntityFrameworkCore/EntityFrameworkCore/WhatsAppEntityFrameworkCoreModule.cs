using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyTattooShop.WhatsApp.EntityFrameworkCore;

[DependsOn(
    typeof(WhatsAppDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class WhatsAppEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<WhatsAppDbContext>(options =>
        {
            options.AddDefaultRepositories<IWhatsAppDbContext>(includeAllEntities: true);
            
            /* Add custom repositories here. Example:
            * options.AddRepository<Question, EfCoreQuestionRepository>();
            */
        });
    }
}
