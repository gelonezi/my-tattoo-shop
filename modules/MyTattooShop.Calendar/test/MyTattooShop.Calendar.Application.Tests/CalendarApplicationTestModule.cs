using Volo.Abp.Modularity;

namespace MyTattooShop.Calendar;

[DependsOn(
    typeof(CalendarApplicationModule),
    typeof(CalendarDomainTestModule)
    )]
public class CalendarApplicationTestModule : AbpModule
{

}
