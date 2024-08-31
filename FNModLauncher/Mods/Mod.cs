using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNModLauncher.Mods
{
    public enum ModType
    {
        NONE,
        DLL_MOD,
        PAK_MOD,
        DISABLED_MOD
    }

    public class Mod
    {
        public string ModFilePath { get; set; }
        public ModType ModType { get; set; }

        public string GetName()
        {
            return Path.GetFileNameWithoutExtension(ModFilePath)
                .Replace(".disabled", "")
                .Replace(".dll", "")
                .Replace(".pak", ""); // this is so hacky but it may fix it
        }
    }
}
