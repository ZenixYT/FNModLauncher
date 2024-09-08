using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNModLauncher.Utilities
{
    namespace Json
    {
        public class LauncherSettings
        {
            public string DefaultModsServer { get; set; }
            public bool AutoUpdate { get; set; }

            public LauncherSettings()
            {
                this.DefaultModsServer = "https://raw.githubusercontent.com/ZenixYT/FML-Mods/main/mods.json";
                this.AutoUpdate = true;
            }
        }

        public class Instance
        {
            public string Name { get; set; }
            public string BuildPath { get; set; }
            public string AdditionalArgs { get; set; }
            public string ModsPath { get; set; }
        }

        public class Root
        {
            public List<Instance> Instances { get; set; }
            public LauncherSettings Settings { get; set; }

            public Root()
            {
                this.Instances = new List<Instance>();
                this.Settings = new LauncherSettings();
            }

            public void SaveRoot()
            {
                string json = JsonConvert.SerializeObject(this, Formatting.Indented);
                string LADPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ".FNModLauncher");
                if (!Directory.Exists(LADPath))
                    Directory.CreateDirectory(LADPath);
                string jsonPath = Path.Combine(LADPath, "config.json");
                File.WriteAllText(jsonPath, json);
            }
        }
    }
}
