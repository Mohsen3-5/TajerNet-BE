using System.Threading.Tasks;

namespace TajerNet.Data;

public interface ITajerNetDbSchemaMigrator
{
    Task MigrateAsync();
}
