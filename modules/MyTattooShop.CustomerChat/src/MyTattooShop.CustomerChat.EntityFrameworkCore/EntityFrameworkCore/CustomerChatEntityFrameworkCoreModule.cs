using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyTattooShop.CustomerChat.EntityFrameworkCore;

[DependsOn(
    typeof(CustomerChatDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class CustomerChatEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<CustomerChatDbContext>(options =>
        {
            options.AddDefaultRepositories<ICustomerChatDbContext>(includeAllEntities: true);
            
            /* Add custom repositories here. Example:
            * options.AddRepository<Question, EfCoreQuestionRepository>();
            */
        });
    }
}
