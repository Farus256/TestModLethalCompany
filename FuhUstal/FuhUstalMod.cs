using BepInEx;
using BepInEx.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuhUstal
{
    [BepInPlugin(modGuid, modName, modVersion)]
    public class FuhUstalMod : BaseUnityPlugin
    {
        private const string modGuid = "com.fuhustal";
        private const string modName = "FuhUstal";
        private const string modVersion = "1.0.0";

        private readonly HarmonyLib.Harmony harmony = new HarmonyLib.Harmony(modGuid);

        private static FuhUstalMod instance;
        internal ManualLogSource logSource;
        void Awake()
        {
            if (instance != null)
            {
                Destroy(this);
                return;
            }

            logSource = BepInEx.Logging.Logger.CreateLogSource(modGuid);
            
            logSource.LogInfo("FuhUstalMod has been loaded!");

            harmony.PatchAll(typeof(FuhUstalMod));
            harmony.PatchAll(typeof(Patches.PlayerControllerBPatch));
        }
    }
}
