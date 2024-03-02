using BepInEx;
using UnityEngine.UIElements.UIR;

namespace FatalAccident
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private const string PLUGIN_GUID = "mrsydar.fatalaccident";
        private const string PLUGIN_NAME = "fatal accident";
        private const string PLUGIN_VERSION = "1.0.0";

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PLUGIN_GUID} is loaded!");
        }
    }
}
