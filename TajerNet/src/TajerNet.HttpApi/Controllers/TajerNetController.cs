using TajerNet.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TajerNet.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TajerNetController : AbpControllerBase
{
    protected TajerNetController()
    {
        LocalizationResource = typeof(TajerNetResource);
    }
}
