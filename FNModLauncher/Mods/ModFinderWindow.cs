using FNModLauncher.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNModLauncher.Mods
{
    public partial class ModFinderWindow : Form
    {
        private readonly string ModPath;
        private List<ListedMod> ListedMods;

        public ModFinderWindow(string ModsPath)
        {
            InitializeComponent();

            this.ModPath = ModsPath;
            this.ListedMods = new List<ListedMod>();
        }

        private void ModFinderWindow_Load(object sender, EventArgs e)
        {
            string modListURL = "https://raw.githubusercontent.com/ZenixYT/FML-Mods/main/mods.json";

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(modListURL);

                ListedMods = JsonConvert.DeserializeObject<List<ListedMod>>(json);
                foreach (var mod in ListedMods)
                {
                    modsBox.Items.Add(mod.Name);
                }
            }
        }

        private void modsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListedMod mod = null;
            foreach (var md in ListedMods)
            {
                if (md.Name == modsBox.SelectedItem.ToString())
                {
                    mod = md;
                    break;
                }
            }

            if (mod != null)
            {
                descLabel.Text = $"Description: {mod.Desc}";
            }
        }

        private void installModButton_Click(object sender, EventArgs e)
        {
            if (modsBox.SelectedItem != null)
            {
                ListedMod mod = null;
                foreach (var md in ListedMods)
                {
                    if (md.Name == modsBox.SelectedItem.ToString())
                    {
                        mod = md;
                        break;
                    }
                }

                if (mod != null)
                {
                    Downloadable modToDownload = new Downloadable();
                    modToDownload.Name = mod.Name;
                    modToDownload.Link = mod.Link;
                    modToDownload.IsFortniteBuild = false;

                    DownloadProgressWindow downloadProgressWindow = new DownloadProgressWindow(modToDownload, ModPath);
                    downloadProgressWindow.Show();
                }
            }
        }

        private void descLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
