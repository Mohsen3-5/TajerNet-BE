using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using TajerNet.Localization;

namespace TajerNet.Web;

[Dependency(ReplaceServices = true)]
public class TajerNetBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<TajerNetResource> _localizer;

    public TajerNetBrandingProvider(IStringLocalizer<TajerNetResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
