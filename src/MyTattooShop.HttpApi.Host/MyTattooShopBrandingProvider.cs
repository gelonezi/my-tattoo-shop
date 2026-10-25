using Microsoft.Extensions.Localization;
using MyTattooShop.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MyTattooShop;

[Dependency(ReplaceServices = true)]
public class MyTattooShopBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<MyTattooShopResource> _localizer;

    public MyTattooShopBrandingProvider(IStringLocalizer<MyTattooShopResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];

    public override string? LogoUrl => "~/images/logo/leptonxlite/logo-light-thumbnail.png";

    public override string? LogoIconUrl => "~/images/logo/leptonxlite/logo-dark-thumbnail.png";
}
