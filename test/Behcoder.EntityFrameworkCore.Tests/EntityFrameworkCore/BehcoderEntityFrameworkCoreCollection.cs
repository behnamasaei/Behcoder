using Xunit;

namespace Behcoder.EntityFrameworkCore;

[CollectionDefinition(BehcoderTestConsts.CollectionDefinitionName)]
public class BehcoderEntityFrameworkCoreCollection : ICollectionFixture<BehcoderEntityFrameworkCoreFixture>
{

}
