using FNModLauncher.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNModLauncher
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void UpdateInstances()
        {
            InstancesBox.Items.Clear();
            foreach (Instance instance in Globals.jsonRoot.Instances)
            {
                InstancesBox.Items.Add(instance.Name);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "config.json");
            if (File.Exists(jsonPath))
            {
                string json = File.ReadAllText(jsonPath);
                Globals.jsonRoot = JsonConvert.DeserializeObject<Root>(json);
            }

            if (Globals.jsonRoot != null)
                UpdateInstances();
            else
                InstancesBox.Items.Clear();
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            var SelectedInstanceBoxItem = InstancesBox.SelectedItem.ToString();
            Instance SelectedInstance = null;
            if (Globals.jsonRoot != null)
            {
                foreach (Instance instance in Globals.jsonRoot.Instances)
                {
                    if (instance.Name == SelectedInstanceBoxItem)
                    {
                        SelectedInstance = instance;
                        break;
                    }
                }
            }

            Launcher launcher = new Launcher(SelectedInstance.BuildPath);
            Thread launchThread = new Thread(() => launcher.Launch(SelectedInstance.ModsPath));
            launchThread.Start();
        }

        private void ModifyBuildButton_Click(object sender, EventArgs e)
        {
            var SelectedInstanceBoxItem = InstancesBox.SelectedItem.ToString();
            Instance SelectedInstance = null;
            if (Globals.jsonRoot != null)
            {
                foreach (Instance instance in Globals.jsonRoot.Instances)
                {
                    if (instance.Name == SelectedInstanceBoxItem)
                    {
                        SelectedInstance = instance;
                        break;
                    }
                }
            }

            if (SelectedInstance != null)
            {
                Globals.jsonRoot.Instances.Remove(SelectedInstance);

                NewInstanceWindow newInstanceWindow = new NewInstanceWindow(this, SelectedInstance);
                newInstanceWindow.Text = "Modify Build";
                newInstanceWindow.Show();
            }
        }

        private void NewBuildButton_Click(object sender, EventArgs e)
        {
            NewInstanceWindow newInstanceWindow = new NewInstanceWindow(this);
            newInstanceWindow.Show();
        }

        private void OpenModsButton_Click(object sender, EventArgs e)
        {
            var SelectedInstanceBoxItem = InstancesBox.SelectedItem.ToString();
            Instance SelectedInstance = null;
            if (Globals.jsonRoot != null)
            {
                foreach (Instance instance in Globals.jsonRoot.Instances)
                {
                    if (instance.Name == SelectedInstanceBoxItem)
                    {
                        SelectedInstance = instance;
                        break;
                    }
                }
            }

            if (SelectedInstance != null)
            {
                if (SelectedInstance.ModsPath != null)
                {
                    Process.Start(SelectedInstance.ModsPath);
                }
            }
        }
    }
}
