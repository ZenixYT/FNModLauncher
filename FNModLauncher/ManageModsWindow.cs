using FNModLauncher.Mods;
using FNModLauncher.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNModLauncher
{
    public partial class ManageModsWindow : Form
    {
        private ModManager modManager;

        public ManageModsWindow(string modPath)
        {
            InitializeComponent();

            modManager = new ModManager(modPath);

            this.AllowDrop = true;
            this.DragEnter += ManageModsWindow_DragEnter;
            this.DragDrop += ManageModsWindow_DragDrop;
        }

        public void UpdateModsBox()
        {
            foreach (Mod mod in modManager.GetMods())
            {
                int i = modListBox.Items.Add(mod.GetName());
                modListBox.SetItemChecked(i, mod.ModType != ModType.DISABLED_MOD ? true : false);
            }
        }

        private void ManageModsWindow_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void ManageModsWindow_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                Mod newMod = modManager.AddNewMod(file);

                UpdateModsBox();
            }
        }
        private void ManageModsWindow_Load(object sender, EventArgs e)
        {
            modListBox.Items.Clear();

            modManager.FetchMods();
            UpdateModsBox();
        }

        private void deleteModButton_Click(object sender, EventArgs e)
        {
            var SelectedItem = modListBox.SelectedItem;
            if (SelectedItem != null)
            {
                var ModName = SelectedItem.ToString();
                foreach (Mod mod in modManager.GetMods())
                {
                    if (ModName == mod.GetName())
                        modListBox.Items.Remove(SelectedItem);
                }
            }
        }
    }
}
