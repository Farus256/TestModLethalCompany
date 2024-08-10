using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;
using GameNetcodeStuff;

namespace FuhUstal.Patches
{
    [HarmonyLib.HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyLib.HarmonyPatch("Update")]
        [HarmonyLib.HarmonyPostfix]
        static void UstalSound(ref float ___sprintMeter)
        {
            
              ___sprintMeter = 1;
            
        }
    }
}
