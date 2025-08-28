using HarmonyLib;
using MGSC;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MapMoveSpeed
{

    /// <summary>
    /// Changes the speed of the camera based on the state of the modifier key.
    /// </summary>
    [HarmonyPatch(typeof(GameCamera), nameof(GameCamera.LateUpdate))]
    public static class GameCamera_LateUpdate_Patch
    {
        public static float DefaultSpeed = -1;


        private static float MoveSpeed;
        private static KeyCode SpeedKey;

        static GameCamera_LateUpdate_Patch()
        {
            Init();
        }

        /// <summary>
        /// Copies the values from the Plugin.Config needed to execute this functionality.
        /// Useful for config updates.
        /// </summary>
        public static void Init()
        {
            MoveSpeed = Plugin.Config.BorderMoveSpeed;
            SpeedKey = Plugin.Config.SpeedKey;
        }
        public static void Prefix(GameCamera __instance)
        {

            if (Input.GetKeyDown(SpeedKey))
            {
                __instance._moveOutsideBorderSpeed = MoveSpeed;
            }

            if (Input.GetKeyUp(SpeedKey))
            {
                __instance._moveOutsideBorderSpeed = DefaultSpeed;
            }
        }
    }
}
