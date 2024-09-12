using Behcoder.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Behcoder.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BehcoderController : AbpControllerBase
{
    protected BehcoderController()
    {
        LocalizationResource = typeof(BehcoderResource);
    }
}
