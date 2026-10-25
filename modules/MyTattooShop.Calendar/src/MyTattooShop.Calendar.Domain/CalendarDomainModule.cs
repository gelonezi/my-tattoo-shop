using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MyTattooShop.Calendar;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(CalendarDomainSharedModule)
)]
public class CalendarDomainModule : AbpModule
{

}
