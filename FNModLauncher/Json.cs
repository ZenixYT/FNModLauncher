using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNModLauncher
{
    namespace Json
    {
        public class Instance
        {
            public string Name { get; set; }
            public string BuildPath { get; set; }
            public string AdditionalArgs { get; set; }
        }

        public class Root
        {
            public List<Instance> Instances { get; set; }

            public Root()
            {
                this.Instances = new List<Instance>();
            }

            public void SaveRoot()
            {
                string json = JsonConvert.SerializeObject(this, Formatting.Indented);
                string jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "config.json");
                File.WriteAllText(jsonPath, json);
            }
        }
    }
}
