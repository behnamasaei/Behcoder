using Behcoder.Samples;
using Xunit;

namespace Behcoder.EntityFrameworkCore.Applications;

[Collection(BehcoderTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BehcoderEntityFrameworkCoreTestModule>
{

}
