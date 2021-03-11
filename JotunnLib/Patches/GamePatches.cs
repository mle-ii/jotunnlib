﻿using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;
using JotunnLib.Managers;

namespace JotunnLib.Patches
{
    class GamePatches
    {

        [HarmonyPatch(typeof(Game), "Awake")]
        public static class AwakePatch
        {
            public static void Prefix(ref Game __instance)
            {
                Debug.Log("----> Game Awake");
                // PieceManager.Load();
            }
        }
    }
}