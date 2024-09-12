using Behcoder.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Behcoder.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BehcoderEntityFrameworkCoreModule),
    typeof(BehcoderApplicationContractsModule)
)]
public class BehcoderDbMigratorModule : AbpModule
{
}
