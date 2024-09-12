using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Behcoder.Data;
using Volo.Abp.DependencyInjection;

namespace Behcoder.EntityFrameworkCore;

public class EntityFrameworkCoreBehcoderDbSchemaMigrator
    : IBehcoderDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBehcoderDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BehcoderDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BehcoderDbContext>()
            .Database
            .MigrateAsync();
    }
}
