using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TajerNet.Data;
using Volo.Abp.DependencyInjection;

namespace TajerNet.EntityFrameworkCore;

public class EntityFrameworkCoreTajerNetDbSchemaMigrator
    : ITajerNetDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTajerNetDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TajerNetDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TajerNetDbContext>()
            .Database
            .MigrateAsync();
    }
}
