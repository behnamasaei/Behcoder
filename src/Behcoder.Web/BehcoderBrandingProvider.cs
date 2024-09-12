using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using Behcoder.Localization;

namespace Behcoder.Web;

[Dependency(ReplaceServices = true)]
public class BehcoderBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BehcoderResource> _localizer;

    public BehcoderBrandingProvider(IStringLocalizer<BehcoderResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
