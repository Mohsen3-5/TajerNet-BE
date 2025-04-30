using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TajerNet.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class TajerNetDbContextFactory : IDesignTimeDbContextFactory<TajerNetDbContext>
{
    public TajerNetDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        TajerNetEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<TajerNetDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new TajerNetDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../TajerNet.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
