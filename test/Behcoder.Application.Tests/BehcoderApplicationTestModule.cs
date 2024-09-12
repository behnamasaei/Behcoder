using Volo.Abp.Modularity;

namespace Behcoder;

[DependsOn(
    typeof(BehcoderApplicationModule),
    typeof(BehcoderDomainTestModule)
)]
public class BehcoderApplicationTestModule : AbpModule
{

}
