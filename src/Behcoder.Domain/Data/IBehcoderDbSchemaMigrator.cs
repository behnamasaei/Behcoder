using System.Threading.Tasks;

namespace Behcoder.Data;

public interface IBehcoderDbSchemaMigrator
{
    Task MigrateAsync();
}
