using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MyTattooShop.TattooJourney.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
