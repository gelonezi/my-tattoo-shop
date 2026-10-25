using MyTattooShop.Calendar.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyTattooShop.Calendar;

public abstract class CalendarController : AbpControllerBase
{
    protected CalendarController()
    {
        LocalizationResource = typeof(CalendarResource);
    }
}
