using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HarmonyLib;
using UnityEngine;

public class BiomeProgressionReworkMod : IModApi
{
    public void InitMod(Mod mod)
    {
        var harmony = new Harmony("com.dropdadeuce.BiomeProgressionRework");
        harmony.PatchAll();
        Debug.Log("[BiomeProgressionRework] Harmony patches applied.");
    }
}