using Volo.Abp.Modularity;

namespace TajerNet;

[DependsOn(
    typeof(TajerNetApplicationModule),
    typeof(TajerNetDomainTestModule)
)]
public class TajerNetApplicationTestModule : AbpModule
{

}
