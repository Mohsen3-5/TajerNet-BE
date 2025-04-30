using Volo.Abp.Modularity;

namespace TajerNet;

[DependsOn(
    typeof(TajerNetDomainModule),
    typeof(TajerNetTestBaseModule)
)]
public class TajerNetDomainTestModule : AbpModule
{

}
