using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNModLauncher.Mods
{
    public class ModManager
    {
        private List<Mod> mods;
        private string modsPath;

        public ModManager(string modsPath)
        {
            mods = new List<Mod>();
            this.modsPath = modsPath;

            if (!Directory.Exists(modsPath))
                Directory.CreateDirectory(modsPath);
        }

        public List<Mod> FetchMods()
        {
            List<Mod> mods = new List<Mod>();
            foreach (string ModFile in Directory.GetFiles(modsPath))
            {
                Mod newMod = new Mod();
                newMod.ModFilePath = ModFile;

                if (ModFile.EndsWith(".dll"))
                    newMod.ModType = ModType.DLL_MOD;
                else if (ModFile.EndsWith(".pak") || ModFile.EndsWith(".sig") || ModFile.EndsWith(".ucas") || ModFile.EndsWith(".utoc"))
                    newMod.ModType = ModType.PAK_MOD;
                else if (ModFile.EndsWith(".disabled"))
                    newMod.ModType = ModType.DISABLED_MOD;

                mods.Add(newMod);
            }

            this.mods = mods;
            return mods;
        }

        public Mod AddNewMod(string ModFile)
        {
            var newModPath = Path.Combine(modsPath, Path.GetFileName(ModFile));
            if (!File.Exists(newModPath))
            {
                File.Copy(ModFile, newModPath);

                Mod mod = new Mod();
                mod.ModFilePath = newModPath;

                if (ModFile.EndsWith(".dll"))
                    mod.ModType = ModType.DLL_MOD;
                else if (ModFile.EndsWith(".pak") || ModFile.EndsWith(".sig") || ModFile.EndsWith(".ucas") || ModFile.EndsWith(".utoc"))
                    mod.ModType = ModType.PAK_MOD;
                else if (ModFile.EndsWith(".disabled"))
                    mod.ModType = ModType.DISABLED_MOD;

                mods.Add(mod);
                return mod;
            }

            return null;
        }

        public void DisableMod(string ModName)
        {
            Mod mod = null;
            foreach (Mod modI in mods)
            {
                if (ModName == modI.GetName())
                {
                    mod = modI;
                    break;
                }
            }

            if (mod != null)
            {
                mods.Remove(mod);

                var newModFileName = mod.ModFilePath + ".disabled";
                if (!File.Exists(newModFileName))
                    File.Move(mod.ModFilePath, newModFileName);
                mod.ModFilePath = newModFileName;

                mod.ModType = ModType.DISABLED_MOD;

                mods.Add(mod);
            }
        }

        public void EnableMod(string ModName)
        {
            Mod mod = null;
            foreach (Mod modI in mods)
            {
                if (ModName == modI.GetName())
                {
                    mod = modI;
                    break;
                }
            }

            if (mod != null)
            {
                mods.Remove(mod);

                var newModFileName = mod.ModFilePath.Replace(".disabled", "");
                if (!File.Exists(newModFileName))
                    File.Move(mod.ModFilePath, newModFileName);
                mod.ModFilePath = newModFileName;

                var ModFile = newModFileName;
                if (ModFile.EndsWith(".dll"))
                    mod.ModType = ModType.DLL_MOD;
                else if (ModFile.EndsWith(".pak") || ModFile.EndsWith(".sig") || ModFile.EndsWith(".ucas") || ModFile.EndsWith(".utoc"))
                    mod.ModType = ModType.PAK_MOD;
                else if (ModFile.EndsWith(".disabled"))
                    mod.ModType = ModType.DISABLED_MOD;

                mods.Add(mod);
            }
        }

        public Mod GetMod(string ModName)
        {
            foreach (Mod modI in mods)
            {
                if (modI.GetName() == ModName)
                    return modI;
            }

            return null;
        }

        public List<Mod> GetMods() { return mods; }
        public string GetModsPath() { return modsPath; }
    }
}