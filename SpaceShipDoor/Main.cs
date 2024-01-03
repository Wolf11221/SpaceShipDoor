using HarmonyLib;
using UnityEngine;

namespace SpaceShipDoor;

public class Main : MonoBehaviour
{
    [HarmonyPatch(typeof(HangarShipDoor), "Update")]
    public class HangarShipDoorPatch
    {
        private static void Prefix(HangarShipDoor __instance)
        {
            if(__instance.buttonsEnabled) return;
            
            __instance.SetDoorButtonsEnabled(true);
        }
    }
    
    [HarmonyPatch(typeof(StartOfRound), "TeleportPlayerInShipIfOutOfRoomBounds")]
    public class StartOfRoundPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }
}