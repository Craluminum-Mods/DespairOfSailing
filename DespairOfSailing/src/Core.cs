using Vintagestory.API.Common;

namespace DespairOfSailing;

public class Core : ModSystem
{
    public override void Start(ICoreAPI api)
    {
        api.Logger.Event("started '{0}' mod", Mod.Info.Name);
    }
}
