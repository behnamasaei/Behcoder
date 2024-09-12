using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Behcoder.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class BehcoderDbContextFactory : IDesignTimeDbContextFactory<BehcoderDbContext>
{
    public BehcoderDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        BehcoderEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<BehcoderDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new BehcoderDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Behcoder.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
