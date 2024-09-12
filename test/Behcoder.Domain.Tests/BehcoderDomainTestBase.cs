using Volo.Abp.Modularity;

namespace Behcoder;

/* Inherit from this class for your domain layer tests. */
public abstract class BehcoderDomainTestBase<TStartupModule> : BehcoderTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
