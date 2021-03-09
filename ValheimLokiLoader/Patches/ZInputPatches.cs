﻿using System;
using System.Collections.Generic;
using UnityEngine;
using HarmonyLib;
using ValheimLokiLoader.Managers;

namespace ValheimLokiLoader.Patches
{
    class ZInputPatches
    {
        [HarmonyPatch(typeof(ZInput), "Initialize")]
        public static class InitializePatch
        {
            public static void Prefix()
            {
                Debug.Log("----> ZInput Initialize");
                InputManager.RegisterInputs();
            }
        }

        [HarmonyPatch(typeof(ZInput), "Reset")]
        public static class ResetPatch
        {
            public static void Postfix(ref ZInput __instance)
            {
                Debug.Log("----> ZInput Reset");
                InputManager.LoadInputs(__instance);
            }
        }
    }
}