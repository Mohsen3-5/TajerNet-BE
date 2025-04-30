using Volo.Abp.Modularity;

namespace TajerNet;

/* Inherit from this class for your domain layer tests. */
public abstract class TajerNetDomainTestBase<TStartupModule> : TajerNetTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
