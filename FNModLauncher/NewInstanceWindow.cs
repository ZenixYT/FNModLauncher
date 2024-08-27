using FNModLauncher.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNModLauncher
{
    public partial class NewInstanceWindow : Form
    {
        private MainWindow mainForm;

        public NewInstanceWindow(MainWindow mainForm, Instance baseInst = null)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            if (baseInst != null)
            {
                InstNameBox.Text = baseInst.Name;
                addArgsBox.Text = baseInst.AdditionalArgs;
                fnDirBox.Text = baseInst.BuildPath;
                modsPathBox.Text = baseInst.ModsPath;
            }
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                bool bValid = true;
                string[] foldersToCheckFor = { "FortniteGame", "Engine" };
                foreach (string folder in foldersToCheckFor)
                {
                    string folderPath = Path.Combine(diag.SelectedPath, folder);
                    if (!Directory.Exists(folderPath))
                    {
                        MessageBox.Show($"You have the wrong Fortnite folder. It must have FortniteGame and Engine folders inside of it. {folderPath}");
                        bValid = false;
                    }
                }

                if (bValid)
                {
                    fnDirBox.Text = diag.SelectedPath;
                    modsPathBox.Text = Path.Combine(diag.SelectedPath, "Mods");
                }
            }
        }

        private void AddInstanceButton_Click(object sender, EventArgs e)
        {
            if (Globals.jsonRoot == null)
                Globals.jsonRoot = new Root();

            Instance newInst = new Instance();
            newInst.Name = InstNameBox.Text;
            newInst.AdditionalArgs = addArgsBox.Text;
            newInst.BuildPath = fnDirBox.Text;
            newInst.ModsPath = modsPathBox.Text;

            Globals.jsonRoot.Instances.Add(newInst);

            this.mainForm.UpdateInstances();

#if !DEBUG
            Globals.jsonRoot.SaveRoot();
#endif

            this.Close();
        }

        private void ModsPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
                modsPathBox.Text = diag.SelectedPath;
        }
    }
}
