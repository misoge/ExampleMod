// Copyright 2024. Misoge. All Rights Reserved.
// ####### Your copyright here #######

#nullable enable

using EggRaiders.UI.Components;
using HarmonyLib;
using UnityEngine;

namespace ExampleMod
{
    [HarmonyPatch(typeof(UIFlicker), "Start")]
    public class LogoPatcher
    {
        [HarmonyPrefix]
        public static void Prefix(UIFlicker __instance)
        {
            __instance.AlphaRange = new Vector2(1f, 2f);
        }

        [HarmonyPostfix]
        public static void Postfix(UIFlicker __instance)
        {
            Debug.Log("UIFlicker.Start() has been patched!");
        }
    }
}