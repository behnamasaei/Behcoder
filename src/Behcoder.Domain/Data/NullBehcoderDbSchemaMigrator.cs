using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Behcoder.Data;

/* This is used if database provider does't define
 * IBehcoderDbSchemaMigrator implementation.
 */
public class NullBehcoderDbSchemaMigrator : IBehcoderDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
