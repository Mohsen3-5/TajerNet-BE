using Volo.Abp.Settings;

namespace TajerNet.Settings;

public class TajerNetSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TajerNetSettings.MySetting1));
    }
}
