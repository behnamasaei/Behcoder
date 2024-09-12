using Volo.Abp.Modularity;

namespace Behcoder;

[DependsOn(
    typeof(BehcoderDomainModule),
    typeof(BehcoderTestBaseModule)
)]
public class BehcoderDomainTestModule : AbpModule
{

}
