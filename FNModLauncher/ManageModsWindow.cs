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
            modManager.FetchMods();

            this.AllowDrop = true;
            this.DragEnter += ManageModsWindow_DragEnter;
            this.DragDrop += ManageModsWindow_DragDrop;

            this.modListBox.ItemCheck += new ItemCheckEventHandler(this.modListBox_ItemCheck);
        }

        public void UpdateModsBox()
        {
            var mods = modManager.GetMods().ToList();

            modListBox.Items.Clear();
            foreach (Mod mod in mods)
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

        private void modListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var State = e.NewValue;
            var Inst = (string)modListBox.Items[e.Index];

            if (State == CheckState.Checked)
            {
                modManager.EnableMod(Inst);
            }
            else if (State == CheckState.Unchecked)
            {
                modManager.DisableMod(Inst);
            }
        }
    }
}
