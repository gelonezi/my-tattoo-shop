using Volo.Abp.Modularity;

namespace MyTattooShop.Calendar;

[DependsOn(
    typeof(CalendarDomainModule),
    typeof(CalendarTestBaseModule)
)]
public class CalendarDomainTestModule : AbpModule
{

}
