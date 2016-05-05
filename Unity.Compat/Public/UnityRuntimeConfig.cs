using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Parse
{
    public static class UnityRuntimeConfig
    {
        public static bool IsWebPlayer;
        public static RuntimePlatform platform;
        public static string persistentDataPath;
    }
}
