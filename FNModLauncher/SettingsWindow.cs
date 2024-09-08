using FNModLauncher.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNModLauncher
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            Globals.jsonRoot.Settings.DefaultModsServer = this.defaultModServerBox.Text;
            Globals.jsonRoot.Settings.AutoUpdate = this.autoUpdateCheck.Checked;

            Globals.jsonRoot.SaveRoot();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            this.defaultModServerBox.Text = Globals.jsonRoot.Settings.DefaultModsServer;
            this.autoUpdateCheck.Checked = Globals.jsonRoot.Settings.AutoUpdate;
        }
    }
}
