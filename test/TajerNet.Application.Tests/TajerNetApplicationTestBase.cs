using Volo.Abp.Modularity;

namespace TajerNet;

public abstract class TajerNetApplicationTestBase<TStartupModule> : TajerNetTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
