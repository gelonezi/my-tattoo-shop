using MyTattooShop.TattooJourney.Localization;
using Volo.Abp.Application.Services;

namespace MyTattooShop.TattooJourney;

public abstract class TattooJourneyAppService : ApplicationService
{
    protected TattooJourneyAppService()
    {
        LocalizationResource = typeof(TattooJourneyResource);
        ObjectMapperContext = typeof(TattooJourneyApplicationModule);
    }
}
