using TajerNet.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TajerNet.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TajerNetEntityFrameworkCoreModule),
    typeof(TajerNetApplicationContractsModule)
)]
public class TajerNetDbMigratorModule : AbpModule
{
}
