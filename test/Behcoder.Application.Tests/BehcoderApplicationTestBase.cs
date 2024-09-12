using Volo.Abp.Modularity;

namespace Behcoder;

public abstract class BehcoderApplicationTestBase<TStartupModule> : BehcoderTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
