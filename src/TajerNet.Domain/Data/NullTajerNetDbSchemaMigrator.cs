using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TajerNet.Data;

/* This is used if database provider does't define
 * ITajerNetDbSchemaMigrator implementation.
 */
public class NullTajerNetDbSchemaMigrator : ITajerNetDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
