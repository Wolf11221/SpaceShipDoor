using System.Reflection;
using BepInEx;
using HarmonyLib;

namespace SpaceShipDoor;

[BepInPlugin(GUID, MODNAME, VERSION)]
public class Plugin : BaseUnityPlugin
{
    public const string
        MODNAME = "SpaceShipDoor",
        AUTHOR = "Nie",
        GUID = AUTHOR + "_" + MODNAME,
        VERSION = "1.0.1";

    public Plugin()
    {
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), null);
    }
}