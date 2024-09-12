using Behcoder.Localization;
using Volo.Abp.Application.Services;

namespace Behcoder;

/* Inherit your application services from this class.
 */
public abstract class BehcoderAppService : ApplicationService
{
    protected BehcoderAppService()
    {
        LocalizationResource = typeof(BehcoderResource);
    }
}
