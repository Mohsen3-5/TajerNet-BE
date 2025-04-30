using TajerNet.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TajerNet.Web.Pages;

public abstract class TajerNetPageModel : AbpPageModel
{
    protected TajerNetPageModel()
    {
        LocalizationResourceType = typeof(TajerNetResource);
    }
}
