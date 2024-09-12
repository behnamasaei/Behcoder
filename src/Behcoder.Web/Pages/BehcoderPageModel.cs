using Behcoder.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Behcoder.Web.Pages;

public abstract class BehcoderPageModel : AbpPageModel
{
    protected BehcoderPageModel()
    {
        LocalizationResourceType = typeof(BehcoderResource);
    }
}
