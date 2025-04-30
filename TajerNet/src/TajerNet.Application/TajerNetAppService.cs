using TajerNet.Localization;
using Volo.Abp.Application.Services;

namespace TajerNet;

/* Inherit your application services from this class.
 */
public abstract class TajerNetAppService : ApplicationService
{
    protected TajerNetAppService()
    {
        LocalizationResource = typeof(TajerNetResource);
    }
}
